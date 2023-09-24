using HardCodeTask.Domain.Entities;

namespace HardCodeTask.Domain.Entities.Categories;
public class CategoryField : BaseEntity<int>
{
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public string Name { get; set; } = string.Empty;
}
