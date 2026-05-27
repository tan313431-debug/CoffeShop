using coffeeshop.Models;
using CoffeeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace coffeeshop.Data
{
    public class CoffeeshopDbContext : DbContext
    {
        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
     new Product
     {
         Id = 1,
         Name = "America",
         Price = 25,
         Detail = "A classic American coffee with a smooth and balanced taste. Brewed with premium beans sourced from South America, this coffee offers a light yet flavorful experience. Perfect for those who enjoy a clean, refreshing cup to start their morning. Its mild bitterness and subtle sweetness make it a favorite among coffee lovers worldwide.",
         ImageUrl = "https://images.unsplash.com/photo-1509042239860-f550ce710b93?w=500",
         IsTrendingProduct = true
     },

     new Product
     {
         Id = 2,
         Name = "Vietnam",
         Price = 20,
         Detail = "Strong Vietnamese coffee crafted with robusta beans and served with sweet condensed milk. This rich, bold brew is a cultural staple of Vietnam. The deep, intense flavor combined with the creamy sweetness creates an unforgettable coffee experience. Best enjoyed over ice on a warm afternoon.",
         ImageUrl = "https://images.unsplash.com/photo-1514432324607-a09d9b4aefdd?w=500",
         IsTrendingProduct = true
     },

     new Product
     {
         Id = 3,
         Name = "United Kingdom",
         Price = 15,
         Detail = "A refined British-style coffee blend inspired by the classic tea culture of the United Kingdom. This smooth, medium-roast coffee carries subtle floral notes and a gentle finish. Crafted for those who appreciate elegance in every sip, it pairs wonderfully with milk or cream for a truly British experience.",
         ImageUrl = "https://images.unsplash.com/photo-1461023058943-07fcbe16d735?w=500",
         IsTrendingProduct = false
     },

     new Product
     {
         Id = 4,
         Name = "India",
         Price = 15,
         Detail = "A warm and aromatic Indian-style coffee infused with cardamom and spices. Inspired by the traditional filter coffee of South India, this blend delivers a rich, spiced flavor profile unlike any other. The combination of freshly ground coffee and exotic spices creates a comforting and deeply satisfying cup.",
         ImageUrl = "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?w=500",
         IsTrendingProduct = false
     },

     new Product
     {
         Id = 5,
         Name = "Russian",
         Price = 25,
         Detail = "A bold and intense Russian-style black coffee designed for those who love a powerful brew. Made from dark-roasted beans with a full-bodied flavor, this coffee delivers a strong, smoky taste with a lingering finish. It is best enjoyed pure and unsweetened to fully appreciate its robust character.",
         ImageUrl = "https://images.unsplash.com/photo-1497515114629-f71d768fd07c?w=500",
         IsTrendingProduct = true
     },

     new Product
     {
         Id = 6,
         Name = "France",
         Price = 35,
         Detail = "A luxurious French press coffee with a rich and aromatic profile. Prepared using the traditional French press method, this coffee extracts the full depth of flavor from premium arabica beans. The result is a velvety, full-bodied cup with a beautiful crema and a long, satisfying aftertaste. A true indulgence for coffee connoisseurs.",
         ImageUrl = "https://images.unsplash.com/photo-1504630083234-14187a9df0f5?w=500",
         IsTrendingProduct = false
     }
 );
        }
    }
}