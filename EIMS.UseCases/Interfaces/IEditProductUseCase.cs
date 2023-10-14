using EIMS.CoreBusiness;

namespace EIMS.UseCases.Interfaces
{
    public interface IEditProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}