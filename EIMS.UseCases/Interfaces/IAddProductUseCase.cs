using EIMS.CoreBusiness;

namespace EIMS.UseCases.Interfaces
{
    public interface IAddProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}