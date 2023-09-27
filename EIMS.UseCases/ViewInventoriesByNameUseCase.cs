using EIMS.CoreBusiness;
using EIMS.UseCases.Interfaces;
using EIMS.UseCases.PluginInterfaces;

namespace EIMS.UseCases
{
    public class ViewInventoriesByNameUseCase: IViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            return await this.inventoryRepository.GetInventoriesByName(name);
        }
    }
}