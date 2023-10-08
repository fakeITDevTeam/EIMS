using EIMS.CoreBusiness;
using EIMS.UseCases.Interfaces;
using EIMS.UseCases.PluginInterfaces;

namespace EIMS.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCase: IViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository _inventoryRepository;

        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await _inventoryRepository.GetInventoriesByName(name);
        }
    }
}