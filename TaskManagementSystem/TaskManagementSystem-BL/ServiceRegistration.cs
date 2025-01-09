using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManagementSystem_BL.Services.Implements;
using TaskManagementSystem_BL.Services.Interfaces;

namespace TaskManagementSystem_BL
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ITopicService, TopicService>();
            services.AddScoped<IEmployeeService,EmployeeService>();
            services.AddScoped<IAssignmentService,AssignmentService>();
            services.AddScoped<ITagService,TagService>();
            return services;
        }
        public static IServiceCollection AddFluentValidation(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining(typeof(ServiceRegistration));
            return services;
        }
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ServiceRegistration));
            return services;
        }
    }
}
