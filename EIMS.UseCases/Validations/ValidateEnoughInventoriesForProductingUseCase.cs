using EIMS.CoreBusiness;
using EIMS.UseCases.Interfaces;
using EIMS.UseCases.PluginInterfaces;
using EIMS.UseCases.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.UseCases.Validations
{
    public class ValidateEnoughInventoriesForProductingUseCase : IValidateEnoughInventoriesForProductingUseCase
    {
        private readonly IProductRepository _productRepository;

        public ValidateEnoughInventoriesForProductingUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> ExecuteAsync(Product product, int quantity)
        {
            var prod = await _productRepository.GetProductByIdAsync(product.ProductId);

            foreach (var pi in prod.ProductInventories)
            {
                if (pi.InventoryQuantity * quantity > pi.Inventory.Quantity)
                    return false;
            }

            return true;
        }
    }
}
