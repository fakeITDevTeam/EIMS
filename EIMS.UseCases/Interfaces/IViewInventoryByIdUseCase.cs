using EIMS.CoreBusiness;

namespace EIMS.UseCases.Interfaces
{
    public interface IViewInventoryByIdUseCase
    {
        Task<Inventory?> ExecuteAsync(int inventoryId);
    }
}