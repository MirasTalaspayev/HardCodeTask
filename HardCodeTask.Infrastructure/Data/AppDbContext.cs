﻿using HardCodeTask.Domain.Entities.Categories;
using HardCodeTask.Domain.Entities.Products;
using HardCodeTask.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCodeTask.Infrastructure.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}

