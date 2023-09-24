using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardCodeTask.Domain.Entities;

namespace HardCodeTask.Domain.Entities.Products;
public class ProductField : BaseEntity<int>
{
    public int ProductId { get; set; }
    public int CategoryFieldId { get; set; }
    public string Value { get; set; } = string.Empty;
}
