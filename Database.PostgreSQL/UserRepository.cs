using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Database.Core;
using Domain;
using Microsoft.Extensions.Logging;
using Npgsql;

namespace Database.PostgreSQL
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(string SqlConnection)
        {
            Connect = () => new NpgsqlConnection(SqlConnection);
        }

        public Func<IDbConnection> Connect { get; }
        public ILogger Logger { get; set; }

        public void Delete(long key)
        {
            using (var c = Connect())
            {
                c.Open();
                c.Execute($@"DELETE FROM USERS WHERE USER_ID = {key}");
            }
        }

        public void Delete(User userInformation)
        {
            using (var c = Connect())
            {
                c.Open();
                c.Execute($@"DELETE FROM USERS WHERE USER_ID = {userInformation.USER_ID}");
            }
        }

        public IEnumerable<User> FindAll()
        {
            using (var c = Connect())
            {
                c.Open();
                return c.Query<User>("SELECT * FROM USERS");
            }
        }

        public void Initialize()
        {
            using (var c = Connect() as NpgsqlConnection)
            {
                c.Open();

                var tableCommand = "CREATE TABLE IF NOT "
                                 + "EXISTS USERS "
                                 + "("
                                 + "USER_ID BIGSERIAL PRIMARY KEY, "
                                 + "PASSWORD TEXT, "
                                 + "USER_NAME TEXT, "
                                 + "USER_GROUP TEXT, "
                                 + "BLOB bytea "
                                 + ")";

                var createTable = new NpgsqlCommand(tableCommand, c);

                createTable.ExecuteReader();
            }
        }

        public void Insert(User user)
        {
            using (var c = Connect())
            {
                c.Open();
                c.Execute(@"INSERT INTO USERS (PASSWORD, USER_NAME, USER_GROUP, BLOB)" +
                                  "VALUES (:PASSWORD, :USER_NAME, :USER_GROUP, :BLOB)", user);
            }
        }
    }
}