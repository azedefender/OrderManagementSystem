using System;

namespace OrderManagementSystem.Domain.Entities;

public class Payment
{
    public int PaymentId { get; set; }

    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;

    public int PaymentMethodId { get; set; }
    public PaymentMethod PaymentMethod { get; set; } = null!;

    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }

    public string TransactionId { get; set; } = null!;
}