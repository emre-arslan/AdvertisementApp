using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Business.Extensions;
using Udemy.AdvertisementApp.Business.Interfaces;
using Udemy.AdvertisementApp.Common;
using Udemy.AdvertisementApp.DataAccess.UnitOfWork;
using Udemy.AdvertisementApp.Dtos;
using Udemy.AdvertisementApp.Entities;

namespace Udemy.AdvertisementApp.Business.Services
{
    public class AppUserService : Service<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>, IAppUserService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        private readonly IValidator<AppUserCreateDto> _createDtoValidator;
        private readonly IValidator<AppUserLoginDto> _userLoginValidator;

        public AppUserService(IMapper mapper, IValidator<AppUserCreateDto> createDtoValidator, IValidator<AppUserUpdateDto> updateDtoValidator, IUow uow, IValidator<AppUserLoginDto> userLoginValidator) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _uow = uow;
            _mapper = mapper;
            _createDtoValidator = createDtoValidator;
            _userLoginValidator = userLoginValidator;
        }


        public async Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId)
        {
            var _validateResponse = _createDtoValidator.Validate(dto);
            if (_validateResponse.IsValid)
            {
                var user = _mapper.Map<AppUser>(dto);
                await _uow.GetRepository<AppUserRole>().CreateAsync(new AppUserRole
                {
                    AppUser = user,
                    AppRoleId = roleId
                });
                await _uow.SaveChangesAsync();

                return new Response<AppUserCreateDto>(ResponseType.Success, dto);
            }

            return new Response<AppUserCreateDto>(dto, _validateResponse.ConvertToCustomValidationError());

        }

        public async Task<IResponse<AppUserListDto>> CheckUserAsync(AppUserLoginDto loginDto)
        {
            var validateResponse = _userLoginValidator.Validate(loginDto);
            if (validateResponse.IsValid)
            {
                var _user = await _uow.GetRepository<AppUser>().GetByFilterAsync(f => f.Username.Equals(loginDto.Username) && f.Password.Equals(loginDto.Password));
                if (_user != null)
                {
                    var appUserDto = _mapper.Map<AppUserListDto>(_user);
                    return new Response<AppUserListDto>(ResponseType.Success, appUserDto);
                }
                return new Response<AppUserListDto>(ResponseType.NotFound, "Not found user");
            }
            return new Response<AppUserListDto>(ResponseType.ValidationError, validateResponse.ConvertToCustomValidationError().Select(s => s.ErrorMessage).ToString());
        }
    }
}
