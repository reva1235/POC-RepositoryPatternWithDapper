using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class PrintService<Employee> : IPrintService<Employee>
    {
        public void Print(IEnumerable<Employee> ts)
        {
            var employees = ts ?? new Employee[] { };

            foreach (var item in ts)
            {
                Console.WriteLine();
            }
        }
    }
}