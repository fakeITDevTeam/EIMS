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

        public async Task<List<Product>> GetProductsByName(string name)
        {
            return await _db.Products.Where(x => x.ProductName.Contains(name, StringComparison.OrdinalIgnoreCase) || string.IsNullOrWhiteSpace(name)).ToListAsync();
        }
    }
}
