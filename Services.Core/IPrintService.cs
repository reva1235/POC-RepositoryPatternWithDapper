using System.Collections;
using System.Collections.Generic;

namespace Services.Core
{
    public interface IPrintService<T>
    {
        void Print(IEnumerable<T> ts);
    }
}