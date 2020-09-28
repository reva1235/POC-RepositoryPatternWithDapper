using Autofac;
using System;

namespace ConsoleApp
{
    public class Program
    {
        private static IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<EmployeeRepository>().As<IEmployeeRepository>();
            builder.RegisterType<Application>();
            builder.RegisterType<EmployeeService>().As<IEmployeeService>();
            builder.RegisterType<PrintService<Employee>>().As<IPrintService<Employee>>();
            return builder.Build();
        }

        public static void Main()
        {
            CompositionRoot().Resolve<Application>().Run();
        }
    }
}
