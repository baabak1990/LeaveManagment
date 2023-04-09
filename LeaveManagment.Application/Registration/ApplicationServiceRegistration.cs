using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using LeaveManagment.Application.Profille;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LeaveManagment.Application.Registration
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection ApplicationRegistraion(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            //This is another way to config autoMapper 
            //services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddMediatR(Assembly.GetExecutingAssembly());
            
            return services;
        }
    }
}
