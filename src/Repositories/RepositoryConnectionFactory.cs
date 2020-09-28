using System;
using System.Collections.Generic;
using System.Text;

namespace poc.Repositories
{
    public enum DbType
    {
        None,
        Oracle,
        Postgre,
        SQLite
    }
    public static class RepositoryFactory<T>
    {
        public static Func<T> Connection(DbType dbType, RepositoryOption repositoryOption)
        {
            switch (dbType)
            {
                case DbType.None:
                    return null;
                case DbType.Oracle:
                    return null;
                case DbType.Postgre:
                    return null;
                case DbType.SQLite:
                    return null;
            }

            return null;
        }
    }
}