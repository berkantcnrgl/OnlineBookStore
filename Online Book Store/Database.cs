using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Online_Book_Store
{
    public class Database
    {
        private static Database databaseObj;
        private SqlConnection sqlConnection;
        private SqlCommand command;
        private SqlDataReader sqlDataReader;
        public int counter = 0;

        private Database()
        {

        }

        public static Database DatabaseObj()
        {
            if (databaseObj == null)
            {
                databaseObj = new Database();
            }

            return databaseObj;
        }

        private string connectionString = "Data Source=den1.mssql8.gear.host;Initial Catalog = bookstore2; User Id=bookstore2; Password=admin.admin";

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool passwordControl(string username, string password)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            command = new SqlCommand("select *from Customer where Username='" + username + "'and Password='" + password + "' ", sqlConnection);
            sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                sqlConnection.Close();
                return true;
            }
            else
            {
                sqlConnection.Close();
                return false;
            }
        }

        public void addCustomer(Customer customer)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            using (command = new SqlCommand("INSERT INTO [dbo].[Customer] ([Id],[Name],[Surname],[Address],[Email],[Username] ,[Password]) VALUES (@Id, @Name, @Surname, @Address, @Email, @Username, @Password)", sqlConnection))
            {
                command.Parameters.AddWithValue("Id", customer.CustomerID.ToString().Trim());
                command.Parameters.AddWithValue("Name", customer.Name.Trim());
                command.Parameters.AddWithValue("Surname", customer.Name.Trim());
                command.Parameters.AddWithValue("Address", customer.Address.Trim());
                command.Parameters.AddWithValue("Email", customer.Email.Trim());
                command.Parameters.AddWithValue("Username", customer.Username.Trim());
                command.Parameters.AddWithValue("Password", customer.Password.Trim());

                command.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }

        public bool usernameControl(string username)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            command = new SqlCommand("select *from Customer where Username='" + username + "' ", sqlConnection);
            sqlDataReader = command.ExecuteReader();
            if (sqlDataReader.Read())
            {
                sqlConnection.Close();
                return true;
            }
            else
            {
                sqlConnection.Close();
                return false;
            }
        }

        public int findCounter()
        {
            using (sqlConnection = new SqlConnection(connectionString))
            {
                command = new SqlCommand("select count(*) from Customer", sqlConnection);
                sqlConnection.Open();
                counter = Convert.ToInt32(command.ExecuteScalar());
                sqlConnection.Close();
            }

            return counter;
        }


    }
}
