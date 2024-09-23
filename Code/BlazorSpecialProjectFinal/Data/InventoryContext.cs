using BlazorSpecialProjectFinal.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.Common;
using System.Diagnostics;
using System.IO.Pipelines;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace BlazorSpecialProjectFinal.Data
{
    public class InventoryContext : DbContext
    {
        public DbSet<Sweet> Sweets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed the database with data
            modelBuilder.Entity<Sweet>().HasData(
                new Sweet { Id = 1, Name = "Acid Pops", 
                    Description = "They are similar to Muggle lollipops, but like most Honeydukes' fare, " +
                    "they have an unconventional, magical twist wherein they are able to burn a hole in the tongue.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Bat's Blood Soup", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Bertie Bott's Every Flavour Beans", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Blood Flavoured Lollipops", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Cauldron Cakes", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Charm Choc", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Cheering Cherry Tart", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Chocoballs", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Chocolate Cauldrons", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Chocolate Frogs", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Chocolate Skeletons", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Chocolate Wands", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Choco-Loco", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Cockroach Clusters", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Crystallised Pineapple", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Drooble's Best Blowing Gum", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Elephant on a Bicycle", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Exploding Bonbons", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Fizzing Whizzbees", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Fudge Flies", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Glacial Snow Flakes", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Honeydukes Best Chocolate", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Honeydukes Mice Pops", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Ice Mice", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Jelly Slugs", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Limas Crazy Blob Drops", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Liquorice Wands", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "No-Melt Ice cream", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Nougat Chunks", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Pepper Imps", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Peppermint Toad", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Pink Coconut Ice", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Pixie Puffs", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Pumpkin fizz", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Pumpkin Pasties", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Salt Water Taffy", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Shock-o-Choc", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Skeletal Sweets", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Spindle's Lick'O'Rish Spiders", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Sugar Quills", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Sugared Butterfly Wings", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Toffees", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Toothflossing Stringmints", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Tooth - Splintering Strongmints", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Treacle fudge", Description = "", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Wizochoc", Description = "", Price = 10.15, Quantity = 100 }
                );
        }
    }
}
