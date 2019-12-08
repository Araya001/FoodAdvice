using FoodAdvice.Data;
using FoodAdvice.Data.EFCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodAdvice.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }

        public static void ConfigurePostgreSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:DeafaultConnection"];
            services.AddDbContext<FoodAdviceContext>(o => o.UseNpgsql(connectionString));
        }

        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddScoped<EfCoreMenuRepository>();
            services.AddScoped<EfCoreIntegradientRepository>();
            services.AddScoped<EfCoreMenuIntegradientRepository>();
            services.AddScoped<EfCoreStepRepository>();
        }
    }
}
