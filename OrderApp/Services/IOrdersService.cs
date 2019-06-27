using OrderApp.Models;
using System.Collections.Generic;

namespace OrderApp.Services
{
    public interface IOrdersService
    {
        Order GetOrder();
        List<(Product product, int quantity)> GetOrderDetails(int OrderId);
        decimal GetOrderTotal(int OrderId);
        (string Message, int Step) GetShippingStatus(int OrderId);
    }
}