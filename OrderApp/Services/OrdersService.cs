using System;
using System.Collections.Generic;
using OrderApp.Models;

namespace OrderApp.Services
{
    public class OrdersService : IOrdersService
    {
        public OrdersService()
        {
        }

        public Order GetOrder() => new Order
        {
            Name = "Rondinele Guimaraes",
            Address = "190 Maria Lopes, Navegantes, SC",
            Phone = "(055)47 964-988-900",
            Date = DateTime.Now.AddDays(-10)
        };

        public List<(Product product, int quantity)> GetOrderDetails(int OrderId) =>
            new List<(Product product, int quantity)>
        {
            (new Product{ ProductId = 1, Name = "Tennis", Price = 100.00M }, 5),
            (new Product{ ProductId = 2, Name = "Meia", Price = 10.00M }, 50),
            (new Product{ ProductId = 3, Name = "Xbox One", Price = 500.00M }, 1),
            (new Product{ ProductId = 4, Name = "Celular", Price = 10000.00M }, 1),
            (new Product{ ProductId = 5, Name = "Bone", Price = 1.00M }, 5000)
        };

        public decimal GetOrderTotal(int OrderId)
        {
            var od = GetOrderDetails(OrderId);
            decimal total = 0.00M;
            od.ForEach(o => total += o.quantity * o.product.Price);

            return total;
        }

        public (string Message, int Step) GetShippingStatus(int OrderId) =>
            ("Para Entrega", 3);
    }
}