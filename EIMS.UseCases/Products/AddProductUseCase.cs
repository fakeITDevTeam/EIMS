using EIMS.CoreBusiness;
using EIMS.UseCases.Interfaces;
using EIMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.UseCases.Products
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IProductRepository _productInventory;

        public AddProductUseCase(IProductRepository productInventory)
        {
            _productInventory = productInventory;
        }

        public async Task ExecuteAsync(Product product)
        {
            if (product == null) return;

            await _productInventory.AddProductAsync(product);
        }
    }
}
