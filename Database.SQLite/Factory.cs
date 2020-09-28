using Microsoft.Data.Sqlite;
using System;

namespace Database.SQLite
{
    public static class Factory
    {
        public static Func<SqliteConnection> CreateConnection(string str = "Data Source=Application.db;Cache=Shared") => () => new SqliteConnection(str);
    }
}
