using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagment
{
    //Order: ID, Список товаров (List<Product>).
    internal class Order
    {
        public int _id;
        public List<Product> _products = new List<Product>();

        public Order(int id)
        {
            _id = id;
        }
    }
}
