using System;
using System.Collections.Generic;

namespace OrderManagementSystem.Domain.Entities;

public class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public int StatusId { get; set; }
    public OrderStatus Status { get; set; } = null!;

    public int PaymentMethodId { get; set; }
    public PaymentMethod PaymentMethod { get; set; } = null!;

    public decimal TotalAmount { get; set; }

    public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
}