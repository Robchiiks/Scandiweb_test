using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Test_scandiweb.Model
{
    public class ProductContext
    {
        public string ConnectionString { get; set; }



        public ProductContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand select = new MySqlCommand("SELECT * FROM products", conn);
                using (MySqlDataReader reader = select.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Product()
                        {
                            SKU = reader.GetInt16("SKU"),
                            Name = reader.GetString("Name"),
                            Price = reader.GetDouble("Price"),
                            Type = reader.GetString("Type")
                        });
                    }
                }
            }
            return list;
        }
    }
}
