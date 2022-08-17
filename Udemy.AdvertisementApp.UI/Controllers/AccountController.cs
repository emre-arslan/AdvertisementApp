using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Business.Interfaces;
using Udemy.AdvertisementApp.Dtos;
using Udemy.AdvertisementApp.UI.Extensions;
using Udemy.AdvertisementApp.UI.Models;

namespace Udemy.AdvertisementApp.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IGenderService _genderService;
        private readonly IValidator<UserCreateModel> _userCreateValidator;
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public AccountController(IGenderService genderService, IValidator<UserCreateModel> userCreateValidator, IAppUserService appUserService, IMapper mapper)
        {
            _genderService = genderService;
            _userCreateValidator = userCreateValidator;
            _appUserService = appUserService;
            _mapper = mapper;
        }

        public async Task<IActionResult> SignUp()
        {
            var getGenders = await _genderService.GetAllAsync();
            var model = new UserCreateModel
            {
                Genders = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(getGenders.Data, "Id", "Definition")
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(UserCreateModel model)
        {
            var validateResponse = _userCreateValidator.Validate(model);
            if (validateResponse.IsValid)
            {

                var dto = _mapper.Map<AppUserCreateDto>(model);
                var createResponse = await _appUserService.CreateAsync(dto);
                return this.ResponseRedirectAction(createResponse, "SignIn");
            }

            foreach (var failure in validateResponse.Errors)
            {
                ModelState.AddModelError(failure.PropertyName, failure.ErrorMessage);
            }

            var response = await _genderService.GetAllAsync();
            model.Genders = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(response.Data, "Id", "Definition", model.GenderId);

            return View(model);
        }
    }
}
