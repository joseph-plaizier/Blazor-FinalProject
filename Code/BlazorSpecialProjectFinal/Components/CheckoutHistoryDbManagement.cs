using BlazorSpecialProjectFinal.Data;
using BlazorSpecialProjectFinal.Objects;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;

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
        private int lastHistoryId = 0;

        public async void AddHistory(QtPurchase QtPurch, string userId)
        {
            _QtPurch = QtPurch;

            _cart = _QtPurch.GetCart();

            _history.HistoryId = await GetLastHistoryID();

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

        private async Task<int> GetLastHistoryID()
        {
            using var db = this.inventoryContext.CreateDbContext();
            await db.CheckOutHistories.OrderByDescending(x => x.HistoryId).FirstOrDefaultAsync();
            
            if(lastHistoryId == 0)
            {
                lastHistoryId = 1;
            }
            else
            {
                lastHistoryId += 1;
            }

            return lastHistoryId;
        }
    }
}
