namespace OrderTrackingApi.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = default!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = default!;
        public DateTime OrderDate { get; set; }
    }
}
