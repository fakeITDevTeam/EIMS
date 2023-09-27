using EIMS.CoreBusiness;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EIMS.Plugins.EFCore
{
    public class EIMSContext: DbContext
    {
        public DbSet<Inventory> Inventories { get; set; }

        public EIMSContext(DbContextOptions options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seeding data
            modelBuilder.Entity<Inventory>().HasData(
                    new Inventory { InventoryId = 1, InventoryName = "Engine", Price = 1000, Quantity = 1 },
                    new Inventory { InventoryId = 2, InventoryName = "Body", Price = 400, Quantity = 1 },
                    new Inventory { InventoryId = 3, InventoryName = "Wheels", Price = 100, Quantity = 1 },
                    new Inventory { InventoryId = 4, InventoryName = "Seat", Price = 50, Quantity = 5 }                    
                );
        }
    }
}
