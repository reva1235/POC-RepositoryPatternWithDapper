using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    public interface IPrintService<T>
    {
        void Print(IEnumerable<T> ts);
    }
}