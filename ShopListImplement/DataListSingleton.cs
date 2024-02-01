using ShopListImplement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopListImplement
{
    internal class DataListSingleton
    {
        private static DataListSingleton? _instance;

        public List<Shop> Shop { get; set; }

        public List<Product> Products { get; set; }

        private DataListSingleton()
        {
            Shop = new List<Shop>();
            Products = new List<Product>();
        }

        public static DataListSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataListSingleton();
            }

            return _instance;
        }
    }
}
