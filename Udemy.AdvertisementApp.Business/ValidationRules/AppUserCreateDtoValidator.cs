using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Dtos;

namespace Udemy.AdvertisementApp.Business.ValidationRules
{
    public class AppUserCreateDtoValidator : AbstractValidator<AppUserCreateDto>
    {
        public AppUserCreateDtoValidator()
        {
            RuleFor(r => r.Firstname).NotEmpty();
            RuleFor(r => r.Password).NotEmpty();
            RuleFor(r => r.Surname).NotEmpty();
            RuleFor(r => r.Username).NotEmpty();
            RuleFor(r => r.GenderId).NotEmpty();
            RuleFor(r => r.PhoneNumber).NotEmpty();
        }
    }
}
