namespace ecommerceNasdak.Models
{
    // Models/Product.cs
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductInventory> Inventories { get; set; }
    }

}
