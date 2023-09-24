namespace HardCodeTask.Application.DTOs.Categories;
public class CategoryDTO : BaseDTO<int>
{
    public string Name { get; set; }
    public List<CategoryFieldDTO> Fields { get; set; }
}

