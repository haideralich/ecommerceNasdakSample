namespace ecommerceNasdak.Models
{

    // Models/ShopOrder.cs
    public class ShopOrder
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<ShopOrderDetail> OrderDetails { get; set; }
    }

}
