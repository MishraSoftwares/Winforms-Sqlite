

namespace WinformsApp.Models
{
    // Models/Customer.cs
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }

    // Models/Product.cs
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
