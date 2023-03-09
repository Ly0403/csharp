using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetProducts
{
    internal class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(localdb)\ProjectModels;initial catalog=ETrade;integrated security=true");
        public List<Product> GetAll()
        {
            CheckConnection();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                products.Add(
                    new Product
                    {
                        Name = reader["Name"].ToString(),
                        Id = Convert.ToInt32(reader["ID"]),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                    }
                );
            }
            reader.Close();
            _connection.Close();
            return products;

        }

        private void CheckConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public DataTable GetAll2()
        {
            CheckConnection();
            SqlCommand command = new SqlCommand("Select * from Products",_connection);
            SqlDataReader reader= command.ExecuteReader();
            DataTable dataTable= new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;

        }

        public void Add(Product product)
        {
            CheckConnection();
            SqlCommand command = new SqlCommand(
                "Insert into Products values (@name, @unitprice, @stock)",_connection);
            command.Parameters.AddWithValue("@name",product.Name);
            command.Parameters.AddWithValue("@unitprice",product.UnitPrice);
            command.Parameters.AddWithValue("@stock",product.Stock);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Product product)
        {
            CheckConnection();
            SqlCommand command = new SqlCommand(
                "Update Products set Name=@name, UnitPrice=@unitprice, Stock=@stock " +
                "where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitprice", product.UnitPrice);
            command.Parameters.AddWithValue("@stock", product.Stock);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int Id)
        {
            CheckConnection();
            SqlCommand command = new SqlCommand(
                "Delete from Products where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
