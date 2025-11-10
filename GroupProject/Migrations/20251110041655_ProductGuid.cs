using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupProject.Migrations
{
    /// <inheritdoc />
    public partial class ProductGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Specifications",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Specifications_ProductId",
                table: "Specifications",
                newName: "IX_Specifications_ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Specifications_Products_ProductID",
                table: "Specifications",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Specifications_Products_ProductID",
                table: "Specifications");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Specifications",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Specifications_ProductID",
                table: "Specifications",
                newName: "IX_Specifications_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Specifications_Products_ProductId",
                table: "Specifications",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
