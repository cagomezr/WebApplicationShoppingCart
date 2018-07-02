using System.Data.Entity;


namespace WebApplicationShoppingCart.Models
{
    public class UserContext : DbContext
    {
        public UserContext() : base("Northwind")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
    }

}