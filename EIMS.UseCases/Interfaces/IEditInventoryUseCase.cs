using EIMS.CoreBusiness;

namespace EIMS.UseCases.Interfaces
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}