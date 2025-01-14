﻿using Framework.Application;

namespace InventoryManagement.Application.Contract.Inventory;

public interface IInventoryApplication
{
    OperationResult Create(CreateInventory command);
    OperationResult Edit(EditInventory command);
    OperationResult Increase(IncreaseInventory command);
    OperationResult Decrease(DecreaseInventory command);
    OperationResult Decrease(List<DecreaseInventory> command);
    EditInventory GetDetails(long id);
    List<InventoryViewModel> Search(InventorySearchModel searchModel);
    List<InventoryOperationViewModel> GetOperationLog(long inventoryId);
}