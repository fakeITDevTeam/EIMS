using EIMS.CoreBusiness;

namespace EIMS.UseCases.Interfaces
{
    public interface IValidateEnoughInventoriesForProductingUseCase
    {
        Task<bool> ExecuteAsync(Product product, int quantity);
    }
}