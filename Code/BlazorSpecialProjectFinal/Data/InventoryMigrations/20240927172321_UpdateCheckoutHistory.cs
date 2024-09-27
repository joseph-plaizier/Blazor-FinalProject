using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorSpecialProjectFinal.Data.InventoryMigrations
{
    /// <inheritdoc />
    public partial class UpdateCheckoutHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheckOutHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistoryId = table.Column<int>(type: "int", nullable: false),
                    SweetId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<int>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckOutHistories", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckOutHistories",
                table: "CheckOutHistories");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CheckOutHistories");

            migrationBuilder.AlterColumn<int>(
                name: "HistoryId",
                table: "CheckOutHistories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckOutHistories",
                table: "CheckOutHistories",
                column: "HistoryId");
        }
    }
}
