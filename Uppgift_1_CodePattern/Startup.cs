using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern
{
    class Startup
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection()
                .AddScoped<IApplication, Application>()
                .AddScoped<IAttendance, Attendance>()
                .AddScoped<ICustomer, Customer>()
                .AddScoped<ICustomerList, CustomerList>()
                .AddScoped<IExtraServices, ExtraServices>()
                .AddScoped<IFactory, Factory>()
                .AddScoped<IPet, Pet>()
                .AddScoped<IPetList, PetList>()
                .AddScoped<IRegister, Register>()
                .BuildServiceProvider();
            return services;
        }
    }
}
