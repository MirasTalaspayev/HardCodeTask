using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardCodeTask.Domain.Entities;
using HardCodeTask.Domain.Entities.Categories;

namespace HardCodeTask.Domain.Entities.Products;
public class ProductField : BaseEntity<int>
{
    public int ProductId { get; set; }
    public int CategoryFieldId { get; set; }
    public Product Product { get; set; }
    public CategoryField CategoryField { get; set; }
    public string Value { get; set; } = string.Empty;
}
