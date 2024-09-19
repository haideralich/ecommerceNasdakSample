namespace ecommerceNasdak.Models
{

    // Models/ProductInventory.cs
    public class ProductInventory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

}
