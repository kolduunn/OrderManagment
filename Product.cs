using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagment
{
    //Product: ID, Название, Цена.
    internal class Product
    {
        public int _id;
        public string _name;
        public double _price;

        public Product(int id, string name, double price)
        {
            _id = id;
            _name = name;
            _price = price;
        }
    }
}
