using Business.Abstract;
using Business.Rules;
using Core.Utilities.Results;
using Core.Utilities.Security.Dtos;
using Core.Utilities.Security.Entities;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Abstracts;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserService _userService;
        private readonly ITokenHelper _tokenHelper;
        private readonly IUserOperationClaimRepository _userOperationClaimRepository;
        private readonly IUserRepository _userRepository;
        private readonly ISellerRepository _sellerRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly UserBusinessRules _rules;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper, IUserOperationClaimRepository userOperationClaimRepository, IUserRepository userRepository, ISellerRepository sellerRepository, ICustomerRepository customerRepository, UserBusinessRules rules)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _userOperationClaimRepository = userOperationClaimRepository;
            _userRepository = userRepository;
            _sellerRepository = sellerRepository;
            _customerRepository = customerRepository;
            _rules = rules;
        }

        public async Task<DataResult<AccessToken>> CreateAccessToken(User user)
        {
            List<OperationClaim> claims = await _userOperationClaimRepository.Query()
            .AsNoTracking().Where(x => x.UserId == user.Id).Select(x => new OperationClaim
            {
                Id = x.OperationClaimId,
                Name = x.OperationClaim.Name
            }).ToListAsync();
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, "Created Token");
        }

        public async Task<DataResult<AccessToken>> CustomerRegister(CustomerForRegisterDto customerForRegisterDto)
        {
            await _rules.UserEmailShouldBeNotExists(customerForRegisterDto.Email);
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(customerForRegisterDto.Password, out passwordHash, out passwordSalt);
            var seller = new Seller
            {
                Username = customerForRegisterDto.Username,
                NationalIdentity = customerForRegisterDto.NationalIdentity,
                DateOfBirth = customerForRegisterDto.DateOfBirth,
                Email = customerForRegisterDto.Email,
                FirstName = customerForRegisterDto.FirstName,
                LastName = customerForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                
            };
            await _sellerRepository.AddAsync(seller);
            var createAccessToken = await CreateAccessToken(seller);
            return new SuccessDataResult<AccessToken>(createAccessToken.Data, "Register Success");
        }

        public async Task<DataResult<AccessToken>> Login(UserForLoginDto userForLoginDto)
        {
            var user = await _userService.GetByMail(userForLoginDto.Email);
            await _rules.UserShouldBeExists(user.Data);
            await _rules.UserEmailShouldBeExists(userForLoginDto.Email);
            await _rules.UserPasswordShouldBeMatch(user.Data.Id, userForLoginDto.Password);
            var createAccessToken = await CreateAccessToken(user.Data);
            return new SuccessDataResult<AccessToken>(createAccessToken.Data, "Login Success");
        }

        public async Task<DataResult<AccessToken>> SellerRegister(SellerForRegisterDto sellerForRegisterDto)
        {
            await _rules.UserEmailShouldBeNotExists(sellerForRegisterDto.Email);
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(sellerForRegisterDto.Password, out passwordHash, out passwordSalt);
            var seller = new Seller
            {
                Username = sellerForRegisterDto.Username,
                NationalIdentity = sellerForRegisterDto.NationalIdentity,
                DateOfBirth = sellerForRegisterDto.DateOfBirth,
                Email = sellerForRegisterDto.Email,
                FirstName = sellerForRegisterDto.FirstName,
                LastName = sellerForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                CompanyName= sellerForRegisterDto.CompanyName,
                PhoneNumber=sellerForRegisterDto.PhoneNumber,
                Address=sellerForRegisterDto.Address,
            };
            await _sellerRepository.AddAsync(seller);
            var createAccessToken = await CreateAccessToken(seller);
            return new SuccessDataResult<AccessToken>(createAccessToken.Data, "Register Success");
        }
    }
}
