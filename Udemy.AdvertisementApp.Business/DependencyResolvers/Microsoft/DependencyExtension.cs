using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Udemy.AdvertisementApp.Business.Interfaces;
using Udemy.AdvertisementApp.Business.Mappings.AutoMapper;
using Udemy.AdvertisementApp.Business.Services;
using Udemy.AdvertisementApp.Business.ValidationRules;
using Udemy.AdvertisementApp.DataAccess.Contexts;
using Udemy.AdvertisementApp.DataAccess.UnitOfWork;
using Udemy.AdvertisementApp.Dtos;
using Udemy.AdvertisementApp.Dtos.GenderDtos;

namespace Udemy.AdvertisementApp.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AdvertisementContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });

            var mapperConfiguration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new ProvidedServiceProfile());
                opt.AddProfile(new AdvertisementProfile());
                opt.AddProfile(new AppUserProfile());
                opt.AddProfile(new GenderProfile());
                //opt.AddProfile();
            });

            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IUow, Uow>();

            services.AddTransient<IValidator<ProvidedServiceCreateDto>, ProvidedServiceCreateDtoValidator>();
            services.AddTransient<IValidator<ProvidedServiceUpdateDto>, ProvidedServiceUpdateDtoValidator>();

            services.AddTransient<IValidator<AdvertisementUpdateDto>, AdvertisementUpdateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementCreateDto>, AdvertisementCreateDtoValidator>();

            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserCreateDto>, AppUserCreateDtoValidator>();

            services.AddTransient<IValidator<GenderCreateDto>, GenderCreateDtoValidator>();
            services.AddTransient<IValidator<GenderUpdateDto>, GenderUpdateDtoValidator>();



            services.AddScoped<IProvidedServiceService, ProvidedServiceService>();
            services.AddScoped<IAdvertisementService, AdvertisementService>();
            services.AddScoped<IAppUserService, AppUserService>();

        }
    }
}
