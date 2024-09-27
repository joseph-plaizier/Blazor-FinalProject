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
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) 
        {
            
        }
        public DbSet<Sweet> Sweets { get; set; }
        public DbSet<CheckOutHistory> CheckOutHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //seed the database with data
            modelBuilder.Entity<Sweet>().HasData(
                new Sweet { 
                    SweetId = 1, 
                    Name = "Acid Pops", 
                    Description = "They are similar to Muggle lollipops, but like most Honeydukes' fare, " +
                    "they have an unconventional, magical twist wherein they are able to burn a hole in the tongue.", 
                    Price = 10.15, 
                    Quantity = 100 },
                new Sweet { 
                    SweetId = 2, 
                    Name = "Bat's Blood Soup", 
                    Description = "A dark red syrup. It is a large, bubbling vat near the front of the shop, into which patrons can dip various sweets into it.", 
                    Price = 10.15, 
                    Quantity = 100 },
                new Sweet { 
                    SweetId = 3, 
                    Name = "Bertie Bott's Every Flavour Beans", 
                    Description = "One of the most popular sweets in the wizarding world. Invented by Bertie Bott, " +
                    "they are almost the same as Muggle jelly beans, except the range encompasses every possible flavour imaginable. " +
                    "There is also no way of telling for sure what flavour any given bean is without tasting it, " +
                    "although you can try and guess by the colour.", 
                    Price = 10.15, 
                    Quantity = 100 },
                new Sweet { 
                    SweetId = 4, 
                    Name = "Blood Flavoured Lollipops", 
                    Description = "Also known as simply Blood Pops are sweets sold in the \"Unusual Tastes\" section", 
                    Price = 10.15, 
                    Quantity = 100 },
                new Sweet { 
                    SweetId = 5, 
                    Name = "Cauldron Cakes", 
                    Description = "A popular wizarding cake varient.", 
                    Price = 10.15, 
                    Quantity = 100 },
                new Sweet { SweetId = 6, Name = "Charm Choc", 
                    Description = "Charmed chocolates.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 7, Name = "Cheering Cherry Tart", 
                    Description = "They magically boost the mood of the consumer for a number of hours.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 8, Name = "Chocoballs", 
                    Description = "Large chocolate sweets with a heavy filling of strawberry mousse and clotted cream.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 9, Name = "Chocolate Cauldrons", 
                    Description = "Boxed chocolates that are filled with Firewhisky and are shaped like cauldrons.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 10, Name = "Chocolate Frogs", 
                    Description = "A very popular wizarding sweet made from chocolate in the form of a frog. " +
                    "They come with a collectible card of a famous witch or wizard in each pack. " +
                    "The frogs are made of seventy percent croakoa. This substance allows them to magically act like an actual frog.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 11, Name = "Chocolate Skeletons", 
                    Description = "Chocolates in the forms of skeletons.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 12, Name = "Chocolate Wands", 
                    Description = "Chocolates in the shape of a wand.  They weigh 1.6 oz or 45 grams.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 13, Name = "Choco-Loco", 
                    Description = "A chocolate varient.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 14, Name = "Cockroach Clusters", 
                    Description = "Sweets made of cockroaches, shaped like peanuts.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 15, Name = "Crystallised Pineapple", 
                    Description = "Small pieces of pineapple cooked in sugar syrup and encrusted with sugar crystal.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 16, Name = "Drooble's Best Blowing Gum", 
                    Description = "Lets you blow bluebell colored bubbles that refuse to pop for days.  It will also never lose its flavor." +
                    "Also available in sugarfree crazyberry flavor as well.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 17, Name = "Elephant on a Bicycle", 
                    Description = "Enables the consumer to produce animal noises.  " +
                    "Some example of these noises are of a lion, an elephant, a monkey, and a train whistle.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 18, Name = "Exploding Bonbons", 
                    Description = "They are made of pure cocoa and coconut dynamite.  " +
                    "They are available in different varieties, such as lavender.  " +
                    "They explode when eaten, though it is unlikely to cause major injury.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 19, Name = "Fizzing Whizzbees", 
                    Description = "They are large sherbet balls that cause a person who sucks on them to float a few inches off the ground.  " +
                    "They contain billywig stings.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 20, Name = "Fudge Flies", 
                    Description = "Chocolate fudge flavored flies", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 21, Name = "Glacial Snow Flakes", 
                    Description = "A melt in the mouth treat.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 22, Name = "Honeydukes Best Chocolate", 
                    Description = "Similar to Muggle chocolate.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 23, Name = "Honeydukes Mice Pops", 
                    Description = "Mice shaped lollipops with eyes and come in assorted fruity flavors.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 24, Name = "Ice Mice", 
                    Description = "Causes the consumer's teeth to chatter and squeak.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 25, Name = "Jelly Slugs", 
                    Description = "Gummy sweets that look like slugs.  Similar to Muggle gummy worms, but longer.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 26, Name = "Limas Crazy Blob Drops", 
                    Description = "A sweet confectionery.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 27, Name = "Liquorice Wands", 
                    Description = "Liquorice in the shape of a wand.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 28, Name = "No-Melt Ice cream", 
                    Description = "Like Muggle ice cream, but it doesn't melt.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 29, Name = "Nougat Chunks", 
                    Description = "A sweet made with either sugar or honey and a type of nut, such as an almond.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 30, Name = "Pepper Imps", 
                    Description = "Small black peppermint sweet that allows the consumer to breath fire and make them smoke at the ears and nose.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 31, Name = "Peppermint Toad", 
                    Description = "A peppermint cream toad that once consumed will hop realistically in the stomach.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 32, Name = "Pink Coconut Ice", 
                    Description = "Shimmering pink square treats.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 33, Name = "Pixie Puffs", 
                    Description = "A breakfast cereal coated with Pixie Dust.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 34, Name = "Pumpkin fizz", 
                    Description = "A carbonated drink with a pumpkin flavor.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 35, Name = "Pumpkin Pasties", 
                    Description = "Similar to a Muggle Cornish pasty, but is filled with pumpkin instead.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 36, Name = "Salt Water Taffy", 
                    Description = "Similar in taste to Muggle Salt Water Taffy, except it makes the consumer want lots of water.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 37, Name = "Shock-o-Choc", 
                    Description = "Chocolate with a bit of a shock.  Comes in chili-powered infused flavors as well.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 38, Name = "Skeletal Sweets", 
                    Description = "Sweets that have the shape and image of skeletons.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 39, Name = "Spindle's Lick'O'Rish Spiders", 
                    Description = "Liquorice flavored sweet shaped like a spider.  Enchanted to look as though it's alive.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 40, Name = "Sugar Quills", 
                    Description = "Delicately spun sugar made to resemble real quills.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 41, Name = "Sugared Butterfly Wings", 
                    Description = "Made with organic butterflies, organice dark chocolate, milk, sugar, and coconut.  " +
                    "They have a shelf life of almost 800 years.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 42, Name = "Toffees", 
                    Description = "Much like Muggle toffee.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 43, Name = "Toothflossing Stringmints", 
                    Description = "When the consumer sucks on them, it flosses the teeth.", 
                    Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 44, Name = "Tooth Splintering Strongmints", 
                    Description = "A strong mint.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 45, Name = "Treacle fudge", 
                    Description = "Much like Muggle treacle fudge.", Price = 10.15, Quantity = 100 },
                new Sweet { SweetId = 46, Name = "Wizochoc", 
                    Description = "Wizarding chocolate.", Price = 10.15, Quantity = 100 }
                );

            modelBuilder.Entity<CheckOutHistory>().HasKey(e => e.Id);
            //modelBuilder.Entity<CheckOutHistory>();
        }

    }
}
