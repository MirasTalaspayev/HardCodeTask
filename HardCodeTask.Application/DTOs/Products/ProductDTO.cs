using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCodeTask.Application.DTOs.Products;
public class ProductDTO : BaseDTO<int>
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public string Category { get; set; } = string.Empty;
    public List<ProductFieldDTO> Fields { get; set; } = new List<ProductFieldDTO>();
}
