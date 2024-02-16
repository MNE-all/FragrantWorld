using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FragrantWorld.Context.Migrations
{
    public partial class EditCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_ClientId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Carts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_ProductArticleNumber",
                table: "Carts",
                column: "ProductArticleNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_ClientId",
                table: "Carts",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_ClientId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_ProductArticleNumber",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Carts");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                columns: new[] { "ProductArticleNumber", "ClientId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_ClientId",
                table: "Carts",
                column: "ClientId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
