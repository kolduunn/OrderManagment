using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagment
{
    //OrderManager:
    //Dictionary<int, Order> – заказы.
    //Методы:
    //CreateOrder(int orderId): Создать заказ.
    //AddProductToOrder(int orderId, Product product): Добавить товар в заказ.
    //GetOrderTotal(int orderId): Получить сумму заказа.
    internal class OrderManager
    {
        public Dictionary<int, Order> _orders = new Dictionary<int, Order>();

        public void CreateOrder(int orderId)
        {
            Order order = new Order(orderId);
            _orders.Add(orderId, order);
        }

        public void AddProductToOrder(int orderId, Product product)
        {
            _orders[orderId]._products.Add(product);
        }

        public void GetOrderTotal(int orderId)
        {
            double total = 0;

            foreach (Order order in _orders.Values)
            {
                total += order._products[orderId]._price;
            }
        }
    }
}
