using HardCodeTask.Domain.Entities;

namespace HardCodeTask.Domain.Entities.Categories;
public class Category : BaseEntity<int>
{
    public string Name { get; set; }
    public List<CategoryField> Fields { get; set; }
}

