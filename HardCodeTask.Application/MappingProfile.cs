using AutoMapper;
using HardCodeTask.Application.DTOs.Categories;
using HardCodeTask.Application.DTOs.Products;
using HardCodeTask.Domain.Entities.Categories;
using HardCodeTask.Domain.Entities.Products;

namespace HardCodeTask.Application;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<ProductDTO, Product>();
        CreateMap<ProductFieldDTO, ProductField>();

        CreateMap<CategoryDTO, Category>();
        CreateMap<CategoryFieldDTO,  CategoryField>();
    }
}
