using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Business.Interfaces;
using Udemy.AdvertisementApp.Common.Enums;
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

        public AccountController(IGenderService genderService, IValidator<UserCreateModel> userCreateValidator, IAppUserService appUserService, IMapper mapper, IValidator<AppUserLoginDto> userLoginValidator)
        {
            _genderService = genderService;
            _userCreateValidator = userCreateValidator;
            _appUserService = appUserService;
            _mapper = mapper;
            _userLoginValidator = userLoginValidator;
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
                var createResponse = await _appUserService.CreateWithRoleAsync(dto, (int)RoleType.Member);
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
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(AppUserLoginDto model)
        {

            if (ModelState.IsValid)
            {
                var user = await _appUserService.CheckUserAsync(model);
                if (user.ResponseType == Common.ResponseType.Success)
                {
                    //ilgili kullanıcının rollerini çekicem.
                    var claims = new List<Claim> { };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = model.RememberMe,
                    };
                }

                ModelState.AddModelError("", user.Message);
            }

            return View(model);
        }
    }
}
