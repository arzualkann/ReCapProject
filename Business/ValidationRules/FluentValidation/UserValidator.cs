﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty().MinimumLength(2).MaximumLength(20);
            RuleFor(p => p.LastName).NotEmpty().MinimumLength(2).MaximumLength(20);
            RuleFor(p => p.Email).NotEmpty().EmailAddress();
            RuleFor(p => p.Password).NotEmpty().MaximumLength(11).MinimumLength(8);
        }
    }
}
