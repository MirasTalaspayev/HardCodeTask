using AutoMapper;
using HardCodeTask.Application.DTOs.Products;
using HardCodeTask.Application.IServices;
using HardCodeTask.Domain.Entities.Products;
using HardCodeTask.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCodeTask.Application.Services;
public class ProductService : BaseService<ProductDTO, Product>, IProductService
{
    public ProductService(AppDbContext db, IMapper mapper) : base(db, mapper)
    {
    }
}
