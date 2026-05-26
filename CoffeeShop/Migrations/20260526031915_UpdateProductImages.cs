using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Detail", "ImageUrl", "IsTrendingProduct" },
                values: new object[] { "Classic American coffee with smooth taste.", "https://images.unsplash.com/photo-1509042239860-f550ce710b93?w=500", true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Detail", "ImageUrl", "IsTrendingProduct" },
                values: new object[] { "Strong Vietnamese coffee with condensed milk.", "https://images.unsplash.com/photo-1514432324607-a09d9b4aefdd?w=500", true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Detail", "ImageUrl" },
                values: new object[] { "British style tea-infused coffee blend.", "https://images.unsplash.com/photo-1461023058943-07fcbe16d735?w=500" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Detail", "ImageUrl" },
                values: new object[] { "Spiced Indian coffee with cardamom.", "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?w=500" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Detail", "ImageUrl", "IsTrendingProduct" },
                values: new object[] { "Bold Russian black coffee.", "https://images.unsplash.com/photo-1497515114629-f71d768fd07c?w=500", true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Detail", "ImageUrl" },
                values: new object[] { "French press coffee with rich aroma.", "https://images.unsplash.com/photo-1504630083234-14187a9df0f5?w=500" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Detail", "ImageUrl", "IsTrendingProduct" },
                values: new object[] { "Name product", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Detail", "ImageUrl", "IsTrendingProduct" },
                values: new object[] { "Vietnamese product", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Detail", "ImageUrl" },
                values: new object[] { "UK product", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Detail", "ImageUrl" },
                values: new object[] { "India product", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Detail", "ImageUrl", "IsTrendingProduct" },
                values: new object[] { "Russian product", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Detail", "ImageUrl" },
                values: new object[] { "France product", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp" });
        }
    }
}
