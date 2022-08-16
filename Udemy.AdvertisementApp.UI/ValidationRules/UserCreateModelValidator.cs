using FluentValidation;
using System;
using Udemy.AdvertisementApp.UI.Models;

namespace Udemy.AdvertisementApp.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            RuleFor(r => r.Password).NotEmpty();
            RuleFor(r => r.Password).MinimumLength(3);
            RuleFor(r => r.Password).Equal(e => e.ConfirmPassword).WithMessage("Password Not Match");
            RuleFor(r => r.Firstname).NotEmpty();
            RuleFor(r => r.Surname).NotEmpty();
            RuleFor(r => r.Username).NotEmpty();
            RuleFor(r => new
            {
                r.Username,
                r.Firstname
            }).Must(x => CanNotFirstname(x.Username, x.Firstname)).WithMessage("username contains firstname").When(w => !string.IsNullOrWhiteSpace(w.Username) && !string.IsNullOrWhiteSpace(w.Firstname));

            RuleFor(r => r.GenderId).NotEmpty();

        }

        private bool CanNotFirstname(string username, string firstname)
        {
            return !username.Contains(firstname);
        }
    }
}
