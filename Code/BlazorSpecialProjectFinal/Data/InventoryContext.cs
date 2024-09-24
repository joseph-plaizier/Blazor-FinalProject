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
                new Sweet { Id = 1, Name = "Bat's Blood Soup", 
                    Description = "A dark red syrup. It is a large, bubbling vat near the front of the shop, into which patrons can dip various sweets into it.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Bertie Bott's Every Flavour Beans", 
                    Description = "One of the most popular sweets in the wizarding world. Invented by Bertie Bott, " +
                    "they are almost the same as Muggle jelly beans, except the range encompasses every possible flavour imaginable. " +
                    "There is also no way of telling for sure what flavour any given bean is without tasting it, " +
                    "although you can try and guess by the colour.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Blood Flavoured Lollipops", 
                    Description = "Also known as simply Blood Pops are sweets sold in the \"Unusual Tastes\" section", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Cauldron Cakes", 
                    Description = "A popular wizarding cake varient.", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Charm Choc", 
                    Description = "Charmed chocolates.", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Cheering Cherry Tart", 
                    Description = "They magically boost the mood of the consumer for a number of hours.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Chocoballs", 
                    Description = "Large chocolate sweets with a heavy filling of strawberry mousse and clotted cream.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Chocolate Cauldrons", 
                    Description = "Boxed chocolates that are filled with Firewhisky and are shaped like cauldrons.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Chocolate Frogs", 
                    Description = "A very popular wizarding sweet made from chocolate in the form of a frog. " +
                    "They come with a collectible card of a famous witch or wizard in each pack. " +
                    "The frogs are made of seventy percent croakoa. This substance allows them to magically act like an actual frog.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Chocolate Skeletons", 
                    Description = "Chocolates in the forms of skeletons.", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Chocolate Wands", 
                    Description = "Chocolates in the shape of a wand.  They weigh 1.6 oz or 45 grams.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Choco-Loco", 
                    Description = "A chocolate varient.", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Cockroach Clusters", 
                    Description = "Sweets made of cockroaches, shaped like peanuts.", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Crystallised Pineapple", 
                    Description = "Small pieces of pineapple cooked in sugar syrup and encrusted with sugar crystal.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Drooble's Best Blowing Gum", 
                    Description = "Lets you blow bluebell colored bubbles that refuse to pop for days.  It will also never lose its flavor." +
                    "Also available in sugarfree crazyberry flavor as well.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Elephant on a Bicycle", 
                    Description = "Enables the consumer to produce animal noises.  " +
                    "Some example of these noises are of a lion, an elephant, a monkey, and a train whistle.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Exploding Bonbons", 
                    Description = "They are made of pure cocoa and coconut dynamite.  " +
                    "They are available in different varieties, such as lavender.  " +
                    "They explode when eaten, though it is unlikely to cause major injury.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Fizzing Whizzbees", 
                    Description = "They are large sherbet balls that cause a person who sucks on them to float a few inches off the ground.  " +
                    "They contain billywig stings.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Fudge Flies", 
                    Description = "Chocolate fudge flavored flies", Price = 10.15, Quantity = 100 },
                new Sweet { Id = 1, Name = "Glacial Snow Flakes", 
                    Description = "", Price = 10.15, Quantity = 100 },
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
