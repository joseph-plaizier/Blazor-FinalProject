﻿// <auto-generated />
using BlazorSpecialProjectFinal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorSpecialProjectFinal.Data.InventoryMigrations
{
    [DbContext(typeof(InventoryContext))]
    partial class InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorSpecialProjectFinal.Objects.CheckOutHistory", b =>
                {
                    b.Property<int>("HistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoryId"));

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SweetId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HistoryId");

                    b.ToTable("CheckOutHistories");
                });

            modelBuilder.Entity("BlazorSpecialProjectFinal.Objects.Sweet", b =>
                {
                    b.Property<int>("SweetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SweetId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("SweetId");

                    b.ToTable("Sweets");

                    b.HasData(
                        new
                        {
                            SweetId = 1,
                            Description = "They are similar to Muggle lollipops, but like most Honeydukes' fare, they have an unconventional, magical twist wherein they are able to burn a hole in the tongue.",
                            Name = "Acid Pops",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 2,
                            Description = "A dark red syrup. It is a large, bubbling vat near the front of the shop, into which patrons can dip various sweets into it.",
                            Name = "Bat's Blood Soup",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 3,
                            Description = "One of the most popular sweets in the wizarding world. Invented by Bertie Bott, they are almost the same as Muggle jelly beans, except the range encompasses every possible flavour imaginable. There is also no way of telling for sure what flavour any given bean is without tasting it, although you can try and guess by the colour.",
                            Name = "Bertie Bott's Every Flavour Beans",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 4,
                            Description = "Also known as simply Blood Pops are sweets sold in the \"Unusual Tastes\" section",
                            Name = "Blood Flavoured Lollipops",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 5,
                            Description = "A popular wizarding cake varient.",
                            Name = "Cauldron Cakes",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 6,
                            Description = "Charmed chocolates.",
                            Name = "Charm Choc",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 7,
                            Description = "They magically boost the mood of the consumer for a number of hours.",
                            Name = "Cheering Cherry Tart",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 8,
                            Description = "Large chocolate sweets with a heavy filling of strawberry mousse and clotted cream.",
                            Name = "Chocoballs",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 9,
                            Description = "Boxed chocolates that are filled with Firewhisky and are shaped like cauldrons.",
                            Name = "Chocolate Cauldrons",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 10,
                            Description = "A very popular wizarding sweet made from chocolate in the form of a frog. They come with a collectible card of a famous witch or wizard in each pack. The frogs are made of seventy percent croakoa. This substance allows them to magically act like an actual frog.",
                            Name = "Chocolate Frogs",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 11,
                            Description = "Chocolates in the forms of skeletons.",
                            Name = "Chocolate Skeletons",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 12,
                            Description = "Chocolates in the shape of a wand.  They weigh 1.6 oz or 45 grams.",
                            Name = "Chocolate Wands",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 13,
                            Description = "A chocolate varient.",
                            Name = "Choco-Loco",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 14,
                            Description = "Sweets made of cockroaches, shaped like peanuts.",
                            Name = "Cockroach Clusters",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 15,
                            Description = "Small pieces of pineapple cooked in sugar syrup and encrusted with sugar crystal.",
                            Name = "Crystallised Pineapple",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 16,
                            Description = "Lets you blow bluebell colored bubbles that refuse to pop for days.  It will also never lose its flavor.Also available in sugarfree crazyberry flavor as well.",
                            Name = "Drooble's Best Blowing Gum",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 17,
                            Description = "Enables the consumer to produce animal noises.  Some example of these noises are of a lion, an elephant, a monkey, and a train whistle.",
                            Name = "Elephant on a Bicycle",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 18,
                            Description = "They are made of pure cocoa and coconut dynamite.  They are available in different varieties, such as lavender.  They explode when eaten, though it is unlikely to cause major injury.",
                            Name = "Exploding Bonbons",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 19,
                            Description = "They are large sherbet balls that cause a person who sucks on them to float a few inches off the ground.  They contain billywig stings.",
                            Name = "Fizzing Whizzbees",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 20,
                            Description = "Chocolate fudge flavored flies",
                            Name = "Fudge Flies",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 21,
                            Description = "A melt in the mouth treat.",
                            Name = "Glacial Snow Flakes",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 22,
                            Description = "Similar to Muggle chocolate.",
                            Name = "Honeydukes Best Chocolate",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 23,
                            Description = "Mice shaped lollipops with eyes and come in assorted fruity flavors.",
                            Name = "Honeydukes Mice Pops",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 24,
                            Description = "Causes the consumer's teeth to chatter and squeak.",
                            Name = "Ice Mice",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 25,
                            Description = "Gummy sweets that look like slugs.  Similar to Muggle gummy worms, but longer.",
                            Name = "Jelly Slugs",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 26,
                            Description = "A sweet confectionery.",
                            Name = "Limas Crazy Blob Drops",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 27,
                            Description = "Liquorice in the shape of a wand.",
                            Name = "Liquorice Wands",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 28,
                            Description = "Like Muggle ice cream, but it doesn't melt.",
                            Name = "No-Melt Ice cream",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 29,
                            Description = "A sweet made with either sugar or honey and a type of nut, such as an almond.",
                            Name = "Nougat Chunks",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 30,
                            Description = "Small black peppermint sweet that allows the consumer to breath fire and make them smoke at the ears and nose.",
                            Name = "Pepper Imps",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 31,
                            Description = "A peppermint cream toad that once consumed will hop realistically in the stomach.",
                            Name = "Peppermint Toad",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 32,
                            Description = "Shimmering pink square treats.",
                            Name = "Pink Coconut Ice",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 33,
                            Description = "A breakfast cereal coated with Pixie Dust.",
                            Name = "Pixie Puffs",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 34,
                            Description = "A carbonated drink with a pumpkin flavor.",
                            Name = "Pumpkin fizz",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 35,
                            Description = "Similar to a Muggle Cornish pasty, but is filled with pumpkin instead.",
                            Name = "Pumpkin Pasties",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 36,
                            Description = "Similar in taste to Muggle Salt Water Taffy, except it makes the consumer want lots of water.",
                            Name = "Salt Water Taffy",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 37,
                            Description = "Chocolate with a bit of a shock.  Comes in chili-powered infused flavors as well.",
                            Name = "Shock-o-Choc",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 38,
                            Description = "Sweets that have the shape and image of skeletons.",
                            Name = "Skeletal Sweets",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 39,
                            Description = "Liquorice flavored sweet shaped like a spider.  Enchanted to look as though it's alive.",
                            Name = "Spindle's Lick'O'Rish Spiders",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 40,
                            Description = "Delicately spun sugar made to resemble real quills.",
                            Name = "Sugar Quills",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 41,
                            Description = "Made with organic butterflies, organice dark chocolate, milk, sugar, and coconut.  They have a shelf life of almost 800 years.",
                            Name = "Sugared Butterfly Wings",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 42,
                            Description = "Much like Muggle toffee.",
                            Name = "Toffees",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 43,
                            Description = "When the consumer sucks on them, it flosses the teeth.",
                            Name = "Toothflossing Stringmints",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 44,
                            Description = "A strong mint.",
                            Name = "Tooth Splintering Strongmints",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 45,
                            Description = "Much like Muggle treacle fudge.",
                            Name = "Treacle fudge",
                            Price = 10.15,
                            Quantity = 100
                        },
                        new
                        {
                            SweetId = 46,
                            Description = "Wizarding chocolate.",
                            Name = "Wizochoc",
                            Price = 10.15,
                            Quantity = 100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
