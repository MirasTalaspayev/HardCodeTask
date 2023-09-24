﻿namespace HardCodeTask.Application.DTOs.Products;

public class ProductFieldDTO : BaseDTO<int>
{
    public int ProductId { get; set; }
    public int CategoryFieldId { get; set; }
    public string Value { get; set; } = string.Empty;
}