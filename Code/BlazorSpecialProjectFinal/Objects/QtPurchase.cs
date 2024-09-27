using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace BlazorSpecialProjectFinal.Objects
{
    public class QtPurchase
    {

        [Required(ErrorMessage = "Quantity to purchase is required")]
        [Range(1, 1000, ErrorMessage = "Quantity must be between 1 and 1000")]
        public int qt { get; set; }
        public Sweet? swt { get; set; }

        List<Tuple<Sweet, int>> cart = new List<Tuple<Sweet, int>>();


        private Sweet _sweet = new Sweet();

        public List<Tuple<Sweet, int>> GetCart()
        {
            return cart;
        }

        public void SetCart (Sweet sweet, int qt)
        {
            _sweet = sweet;
            this.qt = qt;

            cart.Add(Tuple.Create(sweet, qt));
        }
    }
}
