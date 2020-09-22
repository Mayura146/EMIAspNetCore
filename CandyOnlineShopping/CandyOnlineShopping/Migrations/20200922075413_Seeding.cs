using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyOnlineShopping.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Chocolate Candy", "Chocolate Candy" },
                    { 2, "Fruit Candy", "Fruit Candy" },
                    { 3, "Gummy Candy", "Gummy Candy" },
                    { 4, "Halloween Candy", "Halloween Candy" },
                    { 5, "Hardy Candy", "Hard Candy" }
                });

            migrationBuilder.InsertData(
                table: "Candy",
                columns: new[] { "CandyId", "CategoryId", "CandyDescription", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "CandyName", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Assorted Chocolate Candy", "\\Images\\thumbnail\\chocolateCandy-small.jpg", "\\Images\\chocolateCandy.jpg", true, false, "Assorted Chocolate Candy", 4.95m },
                    { 2, 1, "Another Assorted Chocolate Candy", "\\Images\\thumbnail\\chocolateCandy2-small.jpg", "\\Images\\chocolateCandy2.jpg", true, true, "Another Assorted Chocolate Candy", 3.95m },
                    { 3, 1, "Another Chocolate Candy.", "\\Images\\thumbnail\\chocolateCandy3-small.jpg", "\\Images\\chocolateCandy3.jpg", true, false, "Another Chocolate Candy", 5.75m },
                    { 4, 2, "Assorted Fruit Candy", "\\Images\\thumbnail\\fruitCandy-small.jpg", "\\Images\\fruitCandy.jpg", true, false, "Assorted Fruit Candy", 3.95m },
                    { 5, 2, "Fruit Candy.", "\\Images\\thumbnail\\fruitCandy2-small.jpg", "\\Images\\fruitCandy2.jpg", true, true, "Fruit Candy", 7.00m },
                    { 6, 2, "Another Assorted Fruit Candy ", "\\Images\\thumbnail\\fruitCandy3-small.jpg", "\\Images\\fruitCandy3.jpg", true, true, "Another Assorted Fruit Candy", 11.25m },
                    { 7, 3, "Assorted Gummy Candy.", "\\Images\\thumbnail\\gummyCandy-small.jpg", "\\Images\\gummyCandy.jpg", true, true, "Assorted Gummy Candy", 3.95m },
                    { 8, 3, "Another Assorted Gummy Candy", "\\Images\\thumbnail\\gummyCandy2-small.jpg", "\\Images\\gummyCandy2.jpg", true, false, "Another Assorted Gummy Candy", 1.95m },
                    { 9, 3, "Gummy Candy", "\\Images\\thumbnail\\gummyCandy3-small.jpg", "\\Images\\gummyCandy3.jpg", true, false, "Gummy Candy", 13.95m },
                    { 10, 4, "Halloween Candy.", "\\Images\\thumbnail\\halloweenCandy-small.jpg", "\\Images\\halloweenCandy.jpg", true, true, "Halloween Candy", 1.95m },
                    { 11, 4, "Assorted Halloween Candy", "\\Images\\thumbnail\\halloweenCandy2-small.jpg", "\\Images\\halloweenCandy2.jpg", true, true, "Assorted Halloween Candy", 12.95m },
                    { 12, 4, "Another Halloween Candy", "\\Images\\thumbnail\\halloweenCandy3-small.jpg", "\\Images\\halloweenCandy3.jpg", true, true, "Another Halloween Candy", 21.95m },
                    { 13, 5, "Hard Candy", "\\Images\\thumbnails\\hardCandy-small.jpg", "\\Images\\hardCandy.jpg", true, false, "Hard Candy", 6.95m },
                    { 14, 5, "Another Hard Candy.", "\\Images\\thumbnail\\hardCandy2-small.jpg", "\\Images\\hardCandy2.jpg", true, true, "Another Hard Candy", 2.95m },
                    { 15, 5, "Best Hard Candy", "\\Images\\thumbnail\\hardCandy3-small.jpg", "\\Images\\hardCandy3.jpg", true, false, "Best Hard Candy", 16.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Candy",
                keyColumn: "CandyId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
