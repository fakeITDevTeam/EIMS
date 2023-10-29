using System.ComponentModel.DataAnnotations;

namespace EIMS.WebApp.ViewModels
{
    public class ProduceViewModel
    {
        [Required]
        public string ProductionNumber { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [Range(minimum: 1, maximum: int.MaxValue, ErrorMessage = "Quantity has to be greater than 0.")]
        public int QuantityToProduce { get; set; }

        public double ProductPrice { get; set; }
    }
}
