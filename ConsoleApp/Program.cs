using Autofac;
using Database.Core;
using Domain;
using Microsoft.Extensions.Logging;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            CompositionRoot().Resolve<Application>().Run();
        }

        private static IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<ConsoleLogger>().As<ILogger>().SingleInstance();

            builder.RegisterType<Application>();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            builder.RegisterType<PrintService<User>>().As<IPrintService<User>>();
            
            
            builder.RegisterType<Database.SQLite.UserRepository>().As<IUserRepository>()
                .PropertiesAutowired()
                .WithParameter("SqlConnection", "Data Source=Application.db;Cache=Shared")
                .OnActivated(s => s.Instance.Initialize());

            builder.RegisterType<Database.PostgreSQL.UserRepository>().As<IUserRepository>()
                .PropertiesAutowired()
                .WithParameter("SqlConnection", "Host=localhost;Database=mlsdb;Username=mlsuser;Password=mlsuser;")
                .OnActivated(s => s.Instance.Initialize());

            return builder.Build();
        }
    }
}