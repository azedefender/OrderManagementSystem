namespace OrderManagementSystem.Domain.Entities;

public class OrderStatus
{
    public int StatusId { get; set; }
    public string Name { get; set; } = null!;
    public int SortOrder { get; set; }
}