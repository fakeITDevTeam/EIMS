using EIMS.CoreBusiness;
using EIMS.UseCases.Interfaces;
using EIMS.UseCases.PluginInterfaces;

namespace EIMS.UseCases.Products
{
    public class ViewProductsByNameUseCase : IViewProductsByNameUseCase
    {
        private readonly IProductRepository _productRepository;

        public ViewProductsByNameUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //public async Task<List<Product>> ExecuteASync(string name = "")
        //{
        //    return await _productRepository.GetProductsByName(name);
        //}

        public async Task<IEnumerable<Product>> ExecuteASync(string name = "")
        {
            return await _productRepository.GetProductsByNameAsync(name);
        }
    }
}
