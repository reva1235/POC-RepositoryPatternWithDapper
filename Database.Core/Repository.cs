using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Database.Core
{
    public abstract class Repository<T>
    {
        public Func<IDbConnection> Connect { get; set; }
    }
}
