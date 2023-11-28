using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductHasDiscounts",
                table: "ProductHasDiscounts");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ProductHasDiscounts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductHasDiscounts",
                table: "ProductHasDiscounts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductHasDiscounts_ProductId",
                table: "ProductHasDiscounts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductHasDiscounts",
                table: "ProductHasDiscounts");

            migrationBuilder.DropIndex(
                name: "IX_ProductHasDiscounts_ProductId",
                table: "ProductHasDiscounts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ProductHasDiscounts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductHasDiscounts",
                table: "ProductHasDiscounts",
                columns: new[] { "ProductId", "DiscountId" });
        }
    }
}
