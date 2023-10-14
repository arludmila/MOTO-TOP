using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class IdForSuppProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierProducts",
                table: "SupplierProducts");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SupplierProducts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierProducts",
                table: "SupplierProducts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierProducts_ProductId",
                table: "SupplierProducts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SupplierProducts",
                table: "SupplierProducts");

            migrationBuilder.DropIndex(
                name: "IX_SupplierProducts_ProductId",
                table: "SupplierProducts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SupplierProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SupplierProducts",
                table: "SupplierProducts",
                columns: new[] { "ProductId", "SupplierId" });
        }
    }
}
