using BlazorSpecialProjectFinal.Data;
using BlazorSpecialProjectFinal.Objects;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BlazorSpecialProjectFinal.Components
{
    public class CheckoutHistoryDbManagement : ICheckoutHistoryDbManagement
    {

        private readonly IDbContextFactory<InventoryContext> inventoryContext;

        public CheckoutHistoryDbManagement(IDbContextFactory<InventoryContext> inventoryContext)
        {
            this.inventoryContext = inventoryContext;
        }
        
        private CheckOutHistory _history = new CheckOutHistory();
        private QtPurchase _QtPurch = new QtPurchase();
        private List<Tuple<Sweet, int>> _cart = new List<Tuple<Sweet, int>>();
        private Sweet _sweet = new Sweet();
        private int _qty;

        public void AddHistory(QtPurchase QtPurch, string userId)
        {
            _QtPurch = QtPurch;

            _cart = _QtPurch.GetCart();

            foreach (var item in _cart)
            {
                _sweet = item.Item1;
                _qty = item.Item2;

                //assign history variables with quantity and sweet object values
                _history.SweetId = _sweet.SweetId;
                _history.Name = _sweet.Name;
                _history.Quantity = _qty;
                _history.Description = _sweet.Description;
                _history.Price = _sweet.Price;
                _history.UserId = userId;
                _history.Cost = _qty * _sweet.Price;

                using var db = this.inventoryContext.CreateDbContext();
                db.CheckOutHistories.Add(_history);
                db.SaveChanges();
            }
        }
    }
}
