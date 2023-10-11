using EIMS.CoreBusiness;

namespace EIMS.UseCases.Interfaces
{
    public interface IViewProductsByNameUseCase
    {
        Task<IEnumerable<Product>> ExecuteASync(string name = "");
    }
}