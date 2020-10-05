using Services.Core;
using System;
using System.Collections.Generic;

namespace Services
{
    public class PrintService<T> : IPrintService<T>
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