namespace OrderManagment
{
    internal class Program
    {
//        Задача:
//Реализовать систему управления заказами в магазине.

//Входные данные примерные, напиши свои с клавиатуры:
//var orderManager = new OrderManager();
//        orderManager.CreateOrder(1);
//orderManager.AddProductToOrder(1, new Product(1, "Телефон", 30000));
//Ожидаемый результат:
//Заказ 1 содержит "Телефон".

        static void Main()
        {
            var orderManager = new OrderManager();
            orderManager.CreateOrder(1);
            orderManager.AddProductToOrder(1, new Product(1, "Телефон", 30000));

            Console.WriteLine($"Заказ {orderManager._orders[1]._id} содержит {orderManager._orders[1]._products[0]._name}");
        }
    }
}
