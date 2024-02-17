using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FragrantWorld.Context.Migrations
{
    public partial class EditCartUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Carts_ProductArticleNumber",
                table: "Carts");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductArticleNumber_ClientId",
                table: "Carts",
                columns: new[] { "ProductArticleNumber", "ClientId" },
                unique: true,
                filter: "[ClientId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Carts_ProductArticleNumber_ClientId",
                table: "Carts");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductArticleNumber",
                table: "Carts",
                column: "ProductArticleNumber");
        }
    }
}
