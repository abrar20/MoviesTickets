using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesTickets.Migrations
{
    public partial class FixShoppingCartItemsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoppingCart",
                table: "ShoppingCartItems",
                newName: "ShoppingCartId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoppingCartId",
                table: "ShoppingCartItems",
                newName: "ShoppingCart");
        }
    }
}
