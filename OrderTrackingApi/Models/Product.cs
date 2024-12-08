namespace OrderTrackingApi.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty; // Prevent nullable warning
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
