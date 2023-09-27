using EIMS.CoreBusiness;
using EIMS.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.UseCases.Interfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAsync(string name);
    }
}
