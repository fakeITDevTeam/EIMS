using EIMS.CoreBusiness;
using EIMS.UseCases.Interfaces;
using EIMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.UseCases
{
    public class ViewProductsByNameUseCase : IViewProductsByNameUseCase
    {
        private readonly IProductRepository _productRepository;

        public ViewProductsByNameUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> ExecuteASync(string name = "")
        {
            return await _productRepository.GetProductsByName(name);
        }


    }
}
