using HardCodeTask.Application.DTOs.Categories;
using HardCodeTask.Application.DTOs.Products;
using HardCodeTask.Application.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HardCodeTask.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }
    [HttpPost("add")]
    public bool AddCategory([FromBody] ProductDTO category)
    {
        return _productService.Add(category);
    }
    [HttpGet("{id}")]
    public ProductDTO GetById(int id) 
    {
        return _productService.GetById(id);
    }
    [HttpGet]
    public ICollection<ProductDTO> GetAll()
    {
        return _productService.GetAll();
    }
}
