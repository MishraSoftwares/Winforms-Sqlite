

namespace SqliteDataAccess.Entities
{
    // Models/Customer.cs
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}
