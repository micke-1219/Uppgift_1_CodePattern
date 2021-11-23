using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Uppgift_1_CodePattern.Interfaces;

namespace Uppgift_1_CodePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Startup.ConfigureServices();
            var application = container.GetRequiredService<IApplication>();
            application.Run();
        }
    }
}
