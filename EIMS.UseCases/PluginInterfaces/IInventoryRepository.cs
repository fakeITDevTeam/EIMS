using EIMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoriesByName(string name);
    }
}
