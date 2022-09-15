using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PycApi.Mapper;
using PycApi.Service;
using StackExchange.Redis;
using System;

namespace PycApi.StartUpExtension
{
    public static class ExtensionService
    {
       

        public static void AddServices(this IServiceCollection services)
        {
            // services 
            services.AddScoped<IVehicle_Service,Vehicle_Service>();
            services.AddScoped<IContainer_Service, Container_Service>();
            


            // mapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            services.AddSingleton(mapperConfig.CreateMapper());
        }
    }
}
