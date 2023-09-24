using HardCodeTask.Application.DTOs.Categories;
using HardCodeTask.Application.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HardCodeTask.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    [HttpPost("add")]
    public bool AddCategory([FromBody] CategoryDTO category)
    {
        return _categoryService.Add(category);
    }
    [HttpGet("{id}")]
    public CategoryDTO GetById(int id) 
    {
        return _categoryService.GetById(id);
    }
    [HttpGet]
    public ICollection<CategoryDTO> GetAll()
    {
        return _categoryService.GetAll();
    }
}
