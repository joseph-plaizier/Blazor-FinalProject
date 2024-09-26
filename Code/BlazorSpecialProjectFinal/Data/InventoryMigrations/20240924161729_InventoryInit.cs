using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorSpecialProjectFinal.Data.InventoryMigrations
{
    /// <inheritdoc />
    public partial class InventoryInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sweets",
                columns: table => new
                {
                    SweetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sweets", x => x.SweetId);
                });

            migrationBuilder.InsertData(
                table: "Sweets",
                columns: new[] { "SweetId", "Description", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "They are similar to Muggle lollipops, but like most Honeydukes' fare, they have an unconventional, magical twist wherein they are able to burn a hole in the tongue.", "Acid Pops", 10.15, 100 },
                    { 2, "A dark red syrup. It is a large, bubbling vat near the front of the shop, into which patrons can dip various sweets into it.", "Bat's Blood Soup", 10.15, 100 },
                    { 3, "One of the most popular sweets in the wizarding world. Invented by Bertie Bott, they are almost the same as Muggle jelly beans, except the range encompasses every possible flavour imaginable. There is also no way of telling for sure what flavour any given bean is without tasting it, although you can try and guess by the colour.", "Bertie Bott's Every Flavour Beans", 10.15, 100 },
                    { 4, "Also known as simply Blood Pops are sweets sold in the \"Unusual Tastes\" section", "Blood Flavoured Lollipops", 10.15, 100 },
                    { 5, "A popular wizarding cake varient.", "Cauldron Cakes", 10.15, 100 },
                    { 6, "Charmed chocolates.", "Charm Choc", 10.15, 100 },
                    { 7, "They magically boost the mood of the consumer for a number of hours.", "Cheering Cherry Tart", 10.15, 100 },
                    { 8, "Large chocolate sweets with a heavy filling of strawberry mousse and clotted cream.", "Chocoballs", 10.15, 100 },
                    { 9, "Boxed chocolates that are filled with Firewhisky and are shaped like cauldrons.", "Chocolate Cauldrons", 10.15, 100 },
                    { 10, "A very popular wizarding sweet made from chocolate in the form of a frog. They come with a collectible card of a famous witch or wizard in each pack. The frogs are made of seventy percent croakoa. This substance allows them to magically act like an actual frog.", "Chocolate Frogs", 10.15, 100 },
                    { 11, "Chocolates in the forms of skeletons.", "Chocolate Skeletons", 10.15, 100 },
                    { 12, "Chocolates in the shape of a wand.  They weigh 1.6 oz or 45 grams.", "Chocolate Wands", 10.15, 100 },
                    { 13, "A chocolate varient.", "Choco-Loco", 10.15, 100 },
                    { 14, "Sweets made of cockroaches, shaped like peanuts.", "Cockroach Clusters", 10.15, 100 },
                    { 15, "Small pieces of pineapple cooked in sugar syrup and encrusted with sugar crystal.", "Crystallised Pineapple", 10.15, 100 },
                    { 16, "Lets you blow bluebell colored bubbles that refuse to pop for days.  It will also never lose its flavor.Also available in sugarfree crazyberry flavor as well.", "Drooble's Best Blowing Gum", 10.15, 100 },
                    { 17, "Enables the consumer to produce animal noises.  Some example of these noises are of a lion, an elephant, a monkey, and a train whistle.", "Elephant on a Bicycle", 10.15, 100 },
                    { 18, "They are made of pure cocoa and coconut dynamite.  They are available in different varieties, such as lavender.  They explode when eaten, though it is unlikely to cause major injury.", "Exploding Bonbons", 10.15, 100 },
                    { 19, "They are large sherbet balls that cause a person who sucks on them to float a few inches off the ground.  They contain billywig stings.", "Fizzing Whizzbees", 10.15, 100 },
                    { 20, "Chocolate fudge flavored flies", "Fudge Flies", 10.15, 100 },
                    { 21, "A melt in the mouth treat.", "Glacial Snow Flakes", 10.15, 100 },
                    { 22, "Similar to Muggle chocolate.", "Honeydukes Best Chocolate", 10.15, 100 },
                    { 23, "Mice shaped lollipops with eyes and come in assorted fruity flavors.", "Honeydukes Mice Pops", 10.15, 100 },
                    { 24, "Causes the consumer's teeth to chatter and squeak.", "Ice Mice", 10.15, 100 },
                    { 25, "Gummy sweets that look like slugs.  Similar to Muggle gummy worms, but longer.", "Jelly Slugs", 10.15, 100 },
                    { 26, "A sweet confectionery.", "Limas Crazy Blob Drops", 10.15, 100 },
                    { 27, "Liquorice in the shape of a wand.", "Liquorice Wands", 10.15, 100 },
                    { 28, "Like Muggle ice cream, but it doesn't melt.", "No-Melt Ice cream", 10.15, 100 },
                    { 29, "A sweet made with either sugar or honey and a type of nut, such as an almond.", "Nougat Chunks", 10.15, 100 },
                    { 30, "Small black peppermint sweet that allows the consumer to breath fire and make them smoke at the ears and nose.", "Pepper Imps", 10.15, 100 },
                    { 31, "A peppermint cream toad that once consumed will hop realistically in the stomach.", "Peppermint Toad", 10.15, 100 },
                    { 32, "Shimmering pink square treats.", "Pink Coconut Ice", 10.15, 100 },
                    { 33, "A breakfast cereal coated with Pixie Dust.", "Pixie Puffs", 10.15, 100 },
                    { 34, "A carbonated drink with a pumpkin flavor.", "Pumpkin fizz", 10.15, 100 },
                    { 35, "Similar to a Muggle Cornish pasty, but is filled with pumpkin instead.", "Pumpkin Pasties", 10.15, 100 },
                    { 36, "Similar in taste to Muggle Salt Water Taffy, except it makes the consumer want lots of water.", "Salt Water Taffy", 10.15, 100 },
                    { 37, "Chocolate with a bit of a shock.  Comes in chili-powered infused flavors as well.", "Shock-o-Choc", 10.15, 100 },
                    { 38, "Sweets that have the shape and image of skeletons.", "Skeletal Sweets", 10.15, 100 },
                    { 39, "Liquorice flavored sweet shaped like a spider.  Enchanted to look as though it's alive.", "Spindle's Lick'O'Rish Spiders", 10.15, 100 },
                    { 40, "Delicately spun sugar made to resemble real quills.", "Sugar Quills", 10.15, 100 },
                    { 41, "Made with organic butterflies, organice dark chocolate, milk, sugar, and coconut.  They have a shelf life of almost 800 years.", "Sugared Butterfly Wings", 10.15, 100 },
                    { 42, "Much like Muggle toffee.", "Toffees", 10.15, 100 },
                    { 43, "When the consumer sucks on them, it flosses the teeth.", "Toothflossing Stringmints", 10.15, 100 },
                    { 44, "A strong mint.", "Tooth Splintering Strongmints", 10.15, 100 },
                    { 45, "Much like Muggle treacle fudge.", "Treacle fudge", 10.15, 100 },
                    { 46, "Wizarding chocolate.", "Wizochoc", 10.15, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sweets");
        }
    }
}
