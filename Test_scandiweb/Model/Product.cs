using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_scandiweb.Model
{
    public class Product
    {
        public ProductContext context;

        public int SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }

    }
}
