using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class PrintService<T> : IPrintService<T>
    {
        public void Print(IEnumerable<T> ts)
        {
            var employees = ts ?? new T[] { };

            foreach (var item in ts)
            {
                Console.WriteLine();
            }
        }
    }
}