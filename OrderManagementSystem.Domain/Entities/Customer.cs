using System;
using System.Collections.Generic;

namespace OrderManagementSystem.Domain.Entities;

public class Customer
{
    public int CustomerId { get; set; }
    public string FullName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public DateTime RegistrationDate { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}