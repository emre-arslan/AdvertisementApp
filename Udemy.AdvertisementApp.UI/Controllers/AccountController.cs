using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Business.Interfaces;
using Udemy.AdvertisementApp.UI.Models;

namespace Udemy.AdvertisementApp.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IGenderService _genderService;
        private readonly IValidator<UserCreateModel> _userCreateValidator;

        public AccountController(IGenderService genderService, IValidator<UserCreateModel> userCreateValidator)
        {
            _genderService = genderService;
            _userCreateValidator = userCreateValidator;
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
                return View(model)
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
