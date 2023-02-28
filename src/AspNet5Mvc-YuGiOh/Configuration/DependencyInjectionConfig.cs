using AspNet5Mvc_YuGiOh.Interfaces;
using AspNet5Mvc_YuGiOh.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNet5Mvc_YuGiOh.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration) 
        {
            //ver depois certinho
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<ICardDatabase, CardDatabase>(); //usando AddHttpClient deu erro ver depois
        }
    }
}
