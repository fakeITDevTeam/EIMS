using EIMS.CoreBusiness;
using EIMS.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.Plugins.EFCore
{
    public class ProductRepository : IProductRepository
    {
        private readonly EIMSContext _db;

        public ProductRepository(EIMSContext db)
        {
            _db = db;
        }

        public async Task AddProductAsync(Product product)
        {
            if (_db.Products.Any(x => x.ProductName.Equals(product.ProductName, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }

            _db.Products.Add(product);
            await _db.SaveChangesAsync();                        
        }

        public async Task DeleteProductAsync(int productId)
        {
            var product = await _db.Products.FindAsync(productId);

            if (product != null)
            {
                product.IsActive = false;
                await _db.SaveChangesAsync();
            }
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _db.Products.Include(x => x.ProductInventories).ThenInclude(x => x.Inventory).FirstOrDefaultAsync(x => x.ProductId == productId);
        }

        public async Task<List<Product>> GetProductsByNameAsync(string name)
        {
            return await _db.Products.Where(x => (x.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase) || string.IsNullOrWhiteSpace(name)) && x.IsActive == true).ToListAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            if (_db.Products.Any(x => x.ProductName.Equals(product.ProductName, StringComparison.OrdinalIgnoreCase))) return;

            var vProduct = await _db.Products.FindAsync(product.ProductId);

            if (vProduct != null)
            {
                vProduct.ProductName = product.ProductName;
                vProduct.Price = product.Price;
                vProduct.Quantity = product.Quantity;
                vProduct.ProductInventories = product.ProductInventories;

                await _db.SaveChangesAsync();
            }
        }
    }
}
