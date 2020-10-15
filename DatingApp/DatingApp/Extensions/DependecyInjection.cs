using AutoMapper;
using DatingApp.Api.Mapper;
using DatingApp.Api.Services;
using DatingApp.Api.Services.Interfaces;
using DatingApp.DataModel.Repositories;
using DatingApp.DataModel.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Api.Extensions
{
    public static class DependecyInjection
    {
        public static void ConfigureDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddAutoMapper(typeof(AutoMapperProfile));
        }
    }
}
