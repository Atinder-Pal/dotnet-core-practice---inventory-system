using Microsoft.EntityFrameworkCore.Migrations;

namespace InventorySystemDay1.Migrations
{
    public partial class SeedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "Discontinued", "Name", "Quantity" },
                values: new object[,]
                {
                    { -1, true, "Chopping Board", 3 },
                    { -2, false, "Knife", 20 },
                    { -3, false, "Bowl", 100 },
                    { -4, false, "Plates", 3 },
                    { -5, false, "IPhone", 200 },
                    { -6, false, "IPad", 500 },
                    { -7, false, "Heater", 50 },
                    { -8, false, "Fan", 200 },
                    { -9, false, "Water Bottle", 200 },
                    { -10, false, "Chair", 200 },
                    { -11, true, "Pen", 200 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ID",
                keyValue: -1);
        }
    }
}
