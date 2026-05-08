namespace CoffeShop.Models
{
    public class ErrorViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Detail { get; set; }
        
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public bool IsTrendingProduct { get; set; }

        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
