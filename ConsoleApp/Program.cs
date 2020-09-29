using Autofac;
using Database.Core;
using Domain;
using Microsoft.Data.Sqlite;
using System;
using System.Data;

namespace ConsoleApp
{
    public class Program
    {
        private static IContainer CompositionRoot()
        {
            

            var builder = new ContainerBuilder();
            builder.Register<Func<IDbConnection>>(c => () => new SqliteConnection("Data Source=Application.db;Cache=Shared"));
            builder.RegisterType<Database.SQLite.UserRepository>().As<IUserRepository>();
            builder.RegisterType<Application>();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            builder.RegisterType<PrintService<User>>().As<IPrintService<User>>();
            return builder.Build();
        }

        public static void Main()
        {
            CompositionRoot().Resolve<Application>().Run();
        }
    }
}
