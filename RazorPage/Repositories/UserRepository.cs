using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using RazorPage.Entities;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace RazorPage.Repositories
{
    public class UserRepository
    {
        private const string Id = "Id";
        private const string Name = "Name";
        private const string Password = "Password";
        private const string InvitedBy = "InvitedBy";
        private const string InvitedCode = "InvitedCode";
        private const string BMoney = "BMoney";
        private const string Level = "Level";

        private const string connectionString = @"Data Source=.;
                                                Initial Catalog=18bang;
                                                Integrated security=true;";
        public User GetByName(string name)
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                IDbCommand command = new SqlCommand();
                command.CommandText =
                    $"SELECT {Id},{Name},{Password},{InvitedBy},{InvitedCode},{BMoney},{Level}" +
                    $"FROM [User] " +
                    $"WHERE [Name] = @Name";
                command.Connection = connection;

                IDataParameter paramName = new SqlParameter("@Name", name);
                command.Parameters.Add(paramName);

                IDataReader reader = command.ExecuteReader();

                User user = new User();

                if (!reader.Read())
                {
                    return null;
                }
                if (reader.Read())
                {
                    user.Id = (int)reader["Id"];
                    user.Name = (string)reader["Name"];
                    user.Password = (string)reader["Password"];
                    user.InvitedBy = new User
                    {
                        Id = (int)reader["InvitedBy"]
                    };
                    user.InvitedCode = (string)reader["InvitedCode"];
                    user.BMoney = (int)reader["BMoney"];
                    user.Level = (int)reader["Level"];
                }
                else
                {
                    return null;
                }
                return user;
            }

        }
        public void Save(User user)
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                IDbCommand command = new SqlCommand();
                command.CommandText = 
                    $"INSERT INTO [User]([Name],[Password]) " +
                    $"VALUES(N'@Name',N'@Passowrd')";
                command.Connection = connection;

                IDataParameter paramName = new SqlParameter("@Name", user.Name);
                IDataParameter paramPassword = new SqlParameter("@Passowrd", user.Password);

                command.Parameters.Add(paramName);
                command.Parameters.Add(paramPassword);

                int rows = command.ExecuteNonQuery();
            }
        }
        public User Find(int id)
        {
            User user = new User();
            return user;
        }
    }
}
