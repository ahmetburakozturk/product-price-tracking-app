using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace UITry
{
    public class Database
    {
        SqlConnection _connection = new SqlConnection("Server=localhost;initial catalog=PriceTracking;integrated security=true;");
        
        public List<Item> GetAll(string category,string username)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(@"SELECT * FROM ITEMS JOIN USERS ON USERS.ID=ITEMS.UserID WHERE USERS.username=@USERNAME AND ITEMS.CATEGORY=@CATEGORY", _connection);
            command.Parameters.AddWithValue("@CATEGORY", category);
            command.Parameters.AddWithValue("@USERNAME", username);
            SqlDataReader reader = command.ExecuteReader();
            List<Item> items = new List<Item>();
            while (reader.Read())
            {
                Item item = new Item
                {
                    ID=Convert.ToInt32(reader["ID"]),
                    Urun=reader["Name"].ToString(),
                    Marka=reader["Brand"].ToString(),
                    Alis=Convert.ToDecimal(reader["PriceIn"]),
                    Satis=Convert.ToDecimal(reader["PriceOut"]),
                    Kategori=reader["Category"].ToString()
                };
                items.Add(item);
            }
            reader.Close();
            _connection.Close();
            return items;
        }

        public bool GetUser(string username, string password)
        {
            bool data = false;
            string _username = "";
            string _password = "";
            ConnectionControl();
            SqlCommand command = new SqlCommand(@"SELECT * FROM USERS WHERE USERNAME=@USERNAME", _connection);
            command.Parameters.AddWithValue("@USERNAME", username);
            SqlDataReader reader = command.ExecuteReader();  
            while (reader.Read())
            {
                _username = reader["username"].ToString();
                _password = reader["password"].ToString();
                Check._userIdG = Convert.ToInt32(reader["ID"]);
            }
            if (username == _username && password == _password)
            {
                data= true;
            }
            else
            {
                data = false;
            }
            reader.Close();
            _connection.Close();
            return data;
        }

        public int GetUserID()
        {
            int userId = 0;
            ConnectionControl();
            SqlCommand command = new SqlCommand(@"SELECT ID FROM Users WHERE username=@USERNAME",_connection);
            command.Parameters.AddWithValue("@USERNAME", Check._userNameG);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                userId = Convert.ToInt32(reader["ID"]);
            }
            reader.Close();
            _connection.Close();
            return userId;
        }

        public void DeleteItem(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(@"DELETE FROM ITEMS WHERE ID=@ID", _connection);
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void AddItem(Item item)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(@"INSERT INTO ITEMS(Name,Brand,PriceIn,PriceOut,Category,UserID) VALUES (@NAME,@BRAND,@PRICEIN,@PRICEOUT,@CATEGORY,@USERID)", _connection);
            command.Parameters.AddWithValue("@NAME", item.Urun);
            command.Parameters.AddWithValue("@BRAND", item.Marka);
            command.Parameters.AddWithValue("@PRICEIN", item.Alis);
            command.Parameters.AddWithValue("@PRICEOUT", item.Satis);
            command.Parameters.AddWithValue("@CATEGORY", item.Kategori);
            command.Parameters.AddWithValue("@USERID", item.ID);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void ChangePassword(string password)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(@"UPDATE Users SET password=@password WHERE ID=@ID", _connection);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@ID", Check._userIdG);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
    }
}
