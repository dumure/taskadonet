using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace taskadonet
{
    internal class UsersDB
    {
        private List<User> _users;
        public UsersDB()
        {
            _users = new List<User>();
            string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=SSPI;";
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new(
                    @"USE UsersDB
                      SELECT * FROM Users"
                    , connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    _users.Add(new User() { Name = (string)reader["Name"], Age = (int)reader["Age"], Login = (string)reader["Login"], Password = (string)reader["Password"] });
                }
            }
        }
        public List<User> GetUsers()
        {
            return _users;
        }
        public void AddUser(User user)
        {
            string connectionString = @"Server=DESKTOP-PN0DMCN; Database=TestAdo; Integrated Security=SSPI";
            using (SqlConnection connection = new(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new(
                    @$"USE [UsersDB]
                      GO
                      INSERT INTO Users([Name], Age, [Login], [Password])
                      VALUES(N'{user.Name}', {user.Age}, N'{user.Login}', N'{user.Password}')"
                    , connection);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
