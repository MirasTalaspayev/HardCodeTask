namespace HardCodeTask.Application.DTOs.Categories;

public class CategoryFieldDTO : BaseDTO<int>
{
    public string Name { get; set; }
    public int CategoryId { get; set; }
}