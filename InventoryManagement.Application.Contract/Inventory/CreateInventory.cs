﻿using System.ComponentModel.DataAnnotations;
using Framework.Application;
using ShopManagement.Contracts.Product;

namespace InventoryManagement.Application.Contract.Inventory;

public class CreateInventory
{
    [Range(1,100000, ErrorMessage = ValidationMessages.IsRequired)]
    public long ProductId { get; set; }
    [Range(1, double.MaxValue, ErrorMessage = ValidationMessages.IsRequired)]
    public double UnitPrice { get; set; }
    public List<ProductViewModel> Products { get; set; }
}