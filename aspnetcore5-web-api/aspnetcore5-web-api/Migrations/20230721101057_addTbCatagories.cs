using Microsoft.EntityFrameworkCore.Migrations;

namespace aspnetcore5_web_api.Migrations
{
    public partial class addTbCatagories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "catagoryId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    catagoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    catagoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.catagoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_catagoryId",
                table: "Products",
                column: "catagoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Catagories_catagoryId",
                table: "Products",
                column: "catagoryId",
                principalTable: "Catagories",
                principalColumn: "catagoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Catagories_catagoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Catagories");

            migrationBuilder.DropIndex(
                name: "IX_Products_catagoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "catagoryId",
                table: "Products");
        }
    }
}
