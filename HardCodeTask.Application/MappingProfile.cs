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
        CreateMap<ProductDTO, Product>()
            .ForMember(x => x.Category, option => option.Ignore());
        CreateMap<ProductFieldDTO, ProductField>()
            .ForMember(x => x.CategoryField, option => option.Ignore());

        CreateMap<Product, ProductDTO>()
            .ForMember(x => x.Category, option => option.MapFrom(src => src.Category.Name));
        CreateMap<ProductField, ProductFieldDTO>()
            .ForMember(x => x.CategoryField, option => option.MapFrom(src => src.CategoryField.Name));

        CreateMap<CategoryDTO, Category>();
        CreateMap<CategoryFieldDTO,  CategoryField>();

        CreateMap<Category, CategoryDTO>();
        CreateMap<CategoryField, CategoryFieldDTO>();
    }
}
