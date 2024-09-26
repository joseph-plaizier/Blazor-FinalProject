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

        public void UpdateProduct(int Id, Sweet product)
        {
            if(product == null) throw new ArgumentNullException(nameof(product));
            if (Id != product.SweetId) return;

            using var db = this.inventoryContext.CreateDbContext();
            var productToUpdate = db.Sweets.Find(Id);
            if(productToUpdate is not null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Description = product.Description;
                productToUpdate.Quantity = product.Quantity;
                productToUpdate.Price = product.Price;

                db.SaveChanges();
            }
        }

        public void AddProduct(Sweet product)
        {
            using var db = this.inventoryContext.CreateDbContext();
            db.Sweets.Add(product);

            db.SaveChanges();
        }
    }
}
