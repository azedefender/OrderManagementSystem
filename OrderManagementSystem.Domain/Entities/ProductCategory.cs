using System.Collections.Generic;

namespace OrderManagementSystem.Domain.Entities;

public class ProductCategory
{
    public int CategoryId { get; set; }
    public string Name { get; set; } = null!;

    public int? ParentCategoryId { get; set; }
    public ProductCategory? ParentCategory { get; set; }

    public ICollection<ProductCategory> Children { get; set; } = new List<ProductCategory>();
}