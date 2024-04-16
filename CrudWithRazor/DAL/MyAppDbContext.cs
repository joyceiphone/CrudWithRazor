using Microsoft.EntityFrameworkCore;
using CrudWithRazor.Models;

namespace CrudWithRazor.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options) 
        { 
        }
        public virtual DbSet<Product> Products { get; set; }
    }
}
