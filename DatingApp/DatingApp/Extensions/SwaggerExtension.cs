using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Api.Extensions
{
    public static class SwaggerExtension
    {
        public static void ConfigureSwagger(this ServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "DatingApp" });
            });
                
                
        }

        public static IApplicationBuilder UseClientApi()
    }
}
