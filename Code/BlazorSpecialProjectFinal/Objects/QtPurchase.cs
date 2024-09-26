using System.ComponentModel.DataAnnotations;

namespace BlazorSpecialProjectFinal.Objects
{
    public class QtPurchase
    {
        public QtPurchase()
        {
        }

        [Required(ErrorMessage = "Quantity to purchase is required")]
        [Range(1, 1000, ErrorMessage = "Quantity must be between 1 and 1000")]
        public int qt { get; set; }
        public int SwtId { get; set; }
    }
}
