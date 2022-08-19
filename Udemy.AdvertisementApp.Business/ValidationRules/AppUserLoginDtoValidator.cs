using FluentValidation;

using Udemy.AdvertisementApp.Dtos;

namespace Udemy.AdvertisementApp.Business.ValidationRules
{
    public class AppUserLoginDtoValidator : AbstractValidator<AppUserLoginDto>
    {
        public AppUserLoginDtoValidator()
        {
            RuleFor(r => r.Username).NotEmpty().WithMessage("kullanıcı adı boş geçilemez");
            RuleFor(r => r.Password).NotEmpty();
        }
    }
}
