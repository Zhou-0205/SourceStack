using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using SourceStack.Entities;
using System.Data;

namespace SourceStack.Repository
{
    public class UserRepository
    {
        private const string Id = "Id";
        private const string Name = "Name";
        private const string Password = "Password";
        private const string InvitedBy = "InvitedBy";
        private const string InvitedCode = "InvitedCode";
        private const string BangMoney = "BangMoney";

        string connectionString = 
            @"Data Source=.;Initial Catalog=17Bang;Integrated security=true;";
        public User LogOn(string name)
        {
            using (DbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                IDbCommand command = new SqlCommand();
                command.CommandText =
                    $"SELECT {Id},{Name},{Password},{InvitedBy},{InvitedCode},{BangMoney}" +
                    $"FROM [User] " +
                    $"WHERE [Name] = @Name";
                command.Connection = connection;

                IDataParameter pName = new SqlParameter("@Name", name);
                command.Parameters.Add(pName);

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
                    user.BangMoney = (int)reader["BangMoney"];
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

                IDataParameter pName = new SqlParameter("@Name", user.Name);
                IDataParameter pPassword = new SqlParameter("@Passowrd", user.Password);

                command.Parameters.Add(pName);
                command.Parameters.Add(pPassword);

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
