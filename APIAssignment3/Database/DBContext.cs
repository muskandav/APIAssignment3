

using API3Assignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace API3Assignment.Database
{
    public class DBContext : DbContext
    {
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //define connection string.
            optionsBuilder.UseSqlServer(@"Data Source=MUSKAN\SQLEXPRESS;Initial Catalog=ProductOrderDB;Integrated Security=True");

        }
    }
}
