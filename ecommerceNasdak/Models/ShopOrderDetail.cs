namespace ecommerceNasdak.Models
{

    // Models/ShopOrderDetail.cs
    public class ShopOrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public ShopOrder Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
