using EIMS.CoreBusiness;

namespace EIMS.UseCases.Interfaces
{
    public interface IViewProductsByNameUseCase
    {
        Task<List<Product>> ExecuteASync(string name = "");
    }
}