using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem_Core.Repositories;
using TaskManagementSystem_DAL.Repositories;

namespace TaskManagementSystem_DAL
{
    public static class IServiceRegistration
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IAssignmentRepository, AssignmentRepository>();
            services.AddScoped<ITagRepository,TagRepository>();
            services.AddScoped<ITopicRepository, TopicRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();  

            return services;

        }
    }
}
