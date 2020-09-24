using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyOnlineShopping.Migrations
{
    public partial class changeinImagePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 13,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnail\\hardCandy-small.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 13,
                column: "ImageThumbnailUrl",
                value: "\\Images\\thumbnails\\hardCandy-small.jpg");
        }
    }
}
