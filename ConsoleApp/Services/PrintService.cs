using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class PrintService<T> : IPrintService<T>
    {
        public void Print(IEnumerable<T> ts)
        {
            foreach (var item in ts ?? new T[] { })
            {
                Console.WriteLine(item);
            }
        }
    }
}