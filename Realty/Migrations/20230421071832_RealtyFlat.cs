using Microsoft.EntityFrameworkCore.Migrations;

namespace Realty.Migrations
{
    public partial class RealtyFlat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RealtyFlatItem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    flatid = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false),
                    RealtyFlatId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealtyFlatItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_RealtyFlatItem_Flat_flatid",
                        column: x => x.flatid,
                        principalTable: "Flat",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RealtyFlatItem_flatid",
                table: "RealtyFlatItem",
                column: "flatid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RealtyFlatItem");
        }
    }
}
