using Microsoft.EntityFrameworkCore;
using MiniETrade.Entities.Concrete;

namespace MiniETrade.Dal
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> db) : base(db)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
    }
}