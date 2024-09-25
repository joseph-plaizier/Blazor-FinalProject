using BlazorSpecialProjectFinal.Data;
using BlazorSpecialProjectFinal.Objects;
using Microsoft.EntityFrameworkCore;

namespace BlazorSpecialProjectFinal.Components
{
    public class InventoryDbManagement : IInventoryDbManagement
    {
        private readonly IDbContextFactory<InventoryContext> inventoryContext;

        public InventoryDbManagement(IDbContextFactory<InventoryContext> inventoryContext)
        {
            this.inventoryContext = inventoryContext;
        }

        public List<Sweet> GetSweets()
        {
            using var db = this.inventoryContext.CreateDbContext();
            return db.Sweets.ToList();
        }
    }
}
