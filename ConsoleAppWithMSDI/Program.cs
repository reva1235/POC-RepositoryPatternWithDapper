using System;
using Database.Core;
using Domain;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Services;
using Services.Core;

namespace ConsoleAppWithMSDI
{
    public class Program
    {
        public static void Main()
        {
            CompositionRoot().GetService<Application>().Run();
        }

        private static IServiceProvider CompositionRoot()
        {
            var services = new ServiceCollection();

            services.AddScoped<IUserRepository>(c =>
            {
                var r = new Database.SQLite.UserRepository("Data Source=Application.db;Cache=Shared")
                {
                    Logger = c.GetService<ILogger>()
                };
                r.Initialize();
                return r;
            });

            services.AddSingleton<ILogger, ConsoleLogger>();
            services.AddSingleton<Application>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IPrintService<User>, PrintService<User>>();

            return services.BuildServiceProvider();
        }
    }
}
