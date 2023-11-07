using EIMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.UseCases.PluginInterfaces
{
    public interface IProductTransactionRepository
    {
        Task<IEnumerable<ProductTransaction>> GetProductTransactionAsync(string productName, DateTime? dateFrom, DateTime? dateTo, ProductTransactionType? transactionType);
        
        Task ProduceAsync(string productionNumber, Product product, int quantity, double price, string doneBy);

        Task SellProductAsync(string salesOrderNumber, Product product, int quantity, double price, string doneBy);
    }
}
