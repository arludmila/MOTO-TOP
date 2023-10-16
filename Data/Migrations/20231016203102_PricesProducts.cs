using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class PricesProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "SupplierProducts",
                newName: "SellingPrice");

            migrationBuilder.AddColumn<double>(
                name: "PurchasePrice",
                table: "SupplierProducts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "SupplierProducts");

            migrationBuilder.RenameColumn(
                name: "SellingPrice",
                table: "SupplierProducts",
                newName: "Price");
        }
    }
}
