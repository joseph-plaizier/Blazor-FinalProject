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

        public Sweet GetSweetById(int id)
        {
            using var db = this.inventoryContext.CreateDbContext();
            var sweet = db.Sweets.Find(id);
            if (sweet is not null) return sweet;

            return new Sweet();
        }

        public void DeleteProduct(int Id)
        {
            using var db = this.inventoryContext.CreateDbContext();
            var sweet = db.Sweets.Find(Id);
            if (sweet is null) return;

            db.Sweets.Remove(sweet);
            db.SaveChanges();
        }
    }
}
