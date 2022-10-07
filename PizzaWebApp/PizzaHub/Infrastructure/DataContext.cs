using Microsoft.EntityFrameworkCore;
using PizzaShop.Models;

namespace PizzaShop.Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }





}
