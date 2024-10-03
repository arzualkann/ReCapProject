using Core.DataAccess.EntityFramework;
using Core.Utilities.Security.Entities;
using DataAccess.Abstracts;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.Repositories
{
    public class UserRepository : EfRepositoryBase<User, int, BaseDbContext>, IUserRepository
    {
        public UserRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
