using EIMS.CoreBusiness;

namespace EIMS.UseCases.Interfaces
{
    public interface IViewProductByIdUseCase
    {
        Task<Product> ExecuteAsync(int productId);
    }
}