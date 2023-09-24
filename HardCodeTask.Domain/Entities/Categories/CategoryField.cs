using HardCodeTask.Domain.Entities;

namespace HardCodeTask.Domain.Entities.Categories;
public class CategoryField : BaseEntity<int>
{
    public string Name { get; set; }
    public int CategoryId { get; set; }
}
