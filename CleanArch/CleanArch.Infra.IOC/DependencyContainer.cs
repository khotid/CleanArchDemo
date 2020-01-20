using CleanArch.Application.Services;
using CleanArch.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;

namespace CleanArch.Infra.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();
            //Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }

    }
}
