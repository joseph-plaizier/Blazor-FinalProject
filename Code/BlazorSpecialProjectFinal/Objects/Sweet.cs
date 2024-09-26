//set rules for validations
using System.ComponentModel.DataAnnotations;

namespace BlazorSpecialProjectFinal.Objects
{
    public class Sweet
    {

        public int SweetId { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "Product name can't be longer than 100 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1,1000, ErrorMessage = "Quantity must be between 1 and 1000.")]
		public int Quantity { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, 10000, ErrorMessage = "Price must be between $0.01 and $10,000.")]
        public double Price { get; set; }

        //public string? DeleteChoice { get; set; }
    }
}
