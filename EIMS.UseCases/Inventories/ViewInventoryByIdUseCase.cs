using EIMS.CoreBusiness;
using EIMS.UseCases.Interfaces;
using EIMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.UseCases.Inventories
{
    public class ViewInventoryByIdUseCase : IViewInventoryByIdUseCase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public ViewInventoryByIdUseCase(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<Inventory?> ExecuteAsync(int inventoryId)
        {
            return await _inventoryRepository.GetInventoryByIdAsync(inventoryId);
        }
    }
}
