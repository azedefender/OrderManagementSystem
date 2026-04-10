using OrderManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;

namespace OrderManagementSystem.BLL.Services;

public class OrderService
{
    public Order CreateOrder(Customer customer, List<OrderItem> items)
    {
        var order = new Order
        {
            Customer = customer,
            OrderDate = DateTime.UtcNow,
            Items = items,
            TotalAmount = items.Sum(i => i.LineTotal)
        };

        return order;
    }
}