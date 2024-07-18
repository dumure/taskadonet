using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

/* ! Нужно создать базу данных !

CREATE DATABASE [UsersDB]

USE [UsersDB]

CREATE TABLE [Users] (
    [Id]       INT           IDENTITY (1, 1),
    [Name]     NVARCHAR (32) NOT NULL,
    [Age]      INT           ,
    [Login]    NVARCHAR (32) NOT NULL,
    [Password] NVARCHAR (32) NOT NULL,
);
*/

namespace taskadonet
{
    internal class UsersDB
    {
        private List<User> _users;
        private string _connectionString;
        public UsersDB()
        {
            _users = new List<User>();
            _connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=UsersDB;Integrated Security=SSPI;";
            using (SqlConnection connection = new(_connectionString))
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
            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();
                SqlCommand cmd = new(
                    @$"USE [UsersDB]
                      INSERT INTO Users([Name], Age, [Login], [Password])
                      VALUES(N'{user.Name}', {user.Age}, N'{user.Login}', N'{user.Password}')"
                    , connection);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
