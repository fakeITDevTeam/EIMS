using System.ComponentModel.DataAnnotations;

namespace EIMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        [Required]
        public string? InventoryName { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
    }
}