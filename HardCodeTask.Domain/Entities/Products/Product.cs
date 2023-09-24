using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardCodeTask.Domain.Entities;

namespace HardCodeTask.Domain.Entities.Products;
public class Product : BaseEntity<int>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public List<ProductField> Fields { get; set; } = new List<ProductField>();
}

