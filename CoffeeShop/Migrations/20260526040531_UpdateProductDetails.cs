using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Detail",
                value: "A classic American coffee with a smooth and balanced taste. Brewed with premium beans sourced from South America, this coffee offers a light yet flavorful experience. Perfect for those who enjoy a clean, refreshing cup to start their morning. Its mild bitterness and subtle sweetness make it a favorite among coffee lovers worldwide.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Detail",
                value: "Strong Vietnamese coffee crafted with robusta beans and served with sweet condensed milk. This rich, bold brew is a cultural staple of Vietnam. The deep, intense flavor combined with the creamy sweetness creates an unforgettable coffee experience. Best enjoyed over ice on a warm afternoon.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Detail",
                value: "A refined British-style coffee blend inspired by the classic tea culture of the United Kingdom. This smooth, medium-roast coffee carries subtle floral notes and a gentle finish. Crafted for those who appreciate elegance in every sip, it pairs wonderfully with milk or cream for a truly British experience.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Detail",
                value: "A warm and aromatic Indian-style coffee infused with cardamom and spices. Inspired by the traditional filter coffee of South India, this blend delivers a rich, spiced flavor profile unlike any other. The combination of freshly ground coffee and exotic spices creates a comforting and deeply satisfying cup.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Detail",
                value: "A bold and intense Russian-style black coffee designed for those who love a powerful brew. Made from dark-roasted beans with a full-bodied flavor, this coffee delivers a strong, smoky taste with a lingering finish. It is best enjoyed pure and unsweetened to fully appreciate its robust character.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Detail",
                value: "A luxurious French press coffee with a rich and aromatic profile. Prepared using the traditional French press method, this coffee extracts the full depth of flavor from premium arabica beans. The result is a velvety, full-bodied cup with a beautiful crema and a long, satisfying aftertaste. A true indulgence for coffee connoisseurs.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Detail",
                value: "Classic American coffee with smooth taste.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Detail",
                value: "Strong Vietnamese coffee with condensed milk.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Detail",
                value: "British style tea-infused coffee blend.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "Detail",
                value: "Spiced Indian coffee with cardamom.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Detail",
                value: "Bold Russian black coffee.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "Detail",
                value: "French press coffee with rich aroma.");
        }
    }
}
