using coffeeshop.Data;
using CoffeeShop.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Models.Services
{
    public class OrderRepository : IOrderRepository
    {
        private CoffeeshopDbContext dbContext;
        private IShoppingCartRepository shoppingCartRepository;

        public OrderRepository(CoffeeshopDbContext dbContext, IShoppingCartRepository shoppingCartRepository)
        {
            this.dbContext = dbContext;
            this.shoppingCartRepository = shoppingCartRepository;
        }

        public void PlaceOrder(Order order)
        {
            var shoppingCartItems = shoppingCartRepository.GetAllShoppingCartItems();
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = shoppingCartRepository.GetShoppingCartTotal();
            order.OrderDetails = new List<OrderDetail>();

            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Product = item.Product,
                    ProductId = item.Product.Id,
                    Quantity = item.Qty,
                    Price = item.Product.Price
                };
                order.OrderDetails.Add(orderDetail);
            }

            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }
        public IEnumerable<Order> GetOrdersByEmail(string? email)
        {
            return dbContext.Orders
                .Include(o => o.OrderDetails)
                .ThenInclude(od => od.Product)
                .Where(o => o.Email == email)
                .OrderByDescending(o => o.OrderPlaced)
                .ToList();
        }
    }
}