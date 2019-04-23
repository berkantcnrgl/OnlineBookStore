using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

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

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }

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

        public List<Product> BookLoader()
        {
            List<Product> booklist = new List<Product>();
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            command = new SqlCommand("SELECT * FROM [dbo].[Book]", sqlConnection);
            sqlDataReader = command.ExecuteReader();
            Book book;
            while (sqlDataReader.Read())
            {
                book = new Book("", "", 0);
                book.ID = (string)sqlDataReader["Id"];
                book.Name = (string)sqlDataReader["Name"];
                book.Author = (string)sqlDataReader["Author"];
                book.Isbn = (string)sqlDataReader["Isbn"];
                book.Publisher = (string)sqlDataReader["Publisher"];
                book.Page = (int)sqlDataReader["Page"];
                book.Content = (string)sqlDataReader["BookContent"];
                book.Price = (double)sqlDataReader["Price"];
                book.Category = (string)sqlDataReader["BookSubject"].ToString().Trim();

                try
                {
                    book.Picture = Image.FromFile(Application.StartupPath + @"\Resources\" + book.ID.Trim() + ".jpg");
                }
                catch (Exception)
                {

                }

                booklist.Add(book);
            }
            sqlConnection.Close();
            return booklist;
        }

        public List<Product> MusicCDLoader()
        {
            List<Product> musiclist = new List<Product>();
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            command = new SqlCommand("SELECT * FROM [dbo].[MusicCd]", sqlConnection);
            sqlDataReader = command.ExecuteReader();
            MusicCD music;
            while (sqlDataReader.Read())
            {
                music = new MusicCD("", "", 0);
                music.ID = (string)sqlDataReader["Id"];
                music.Name = (string)sqlDataReader["Name"];
                music.Singer = (string)sqlDataReader["Singer"];
                music.Isbn = (string)sqlDataReader["Isbn"];
                music.Price = (double)sqlDataReader["Price"];
                music.ReleaseDate = (int)sqlDataReader["ReleaseDate"];
                music.Category = MusicCD.GetMusicType((string)sqlDataReader["Type"].ToString().Trim()).ToString();
                music.Content = (string)sqlDataReader["CdContent"];
                try
                {
                    music.Picture = Image.FromFile(Application.StartupPath + @"\Resources\" + music.ID.Trim() + ".jpg");
                }
                catch (Exception)
                {

                }
                musiclist.Add(music);
            }
            sqlConnection.Close();
            return musiclist;
        }
        public List<Product> MagazineLoader()
        {
            List<Product> magazinelist = new List<Product>();
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            command = new SqlCommand("SELECT * FROM [dbo].[Magazine]", sqlConnection);
            sqlDataReader = command.ExecuteReader();
            Magazine magazine;
            while (sqlDataReader.Read())
            {
                magazine = new Magazine("", "", 0);
                magazine.ID = (string)sqlDataReader["Id"];
                magazine.Name = (string)sqlDataReader["Name"];
                magazine.Category = Magazine.GetMagazineType((string)sqlDataReader["Type"].ToString().Trim()).ToString();
                magazine.Issue = (string)sqlDataReader["Issue"];
                magazine.Price = (double)sqlDataReader["Price"];
                magazine.Isbn = (string)sqlDataReader["Isbn"];
                try
                {
                    magazine.Picture = Image.FromFile(Application.StartupPath + @"\Resources\" + magazine.ID.Trim() + ".jpg");
                }
                catch (Exception)
                {

                }
                magazinelist.Add(magazine);
            }
            sqlConnection.Close();
            return magazinelist;
        }

    }
}
