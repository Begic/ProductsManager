using Microsoft.EntityFrameworkCore;
using ProductsManager.Data.Entities;

namespace ProductsManager.Data;

public class DataBaseContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=ProductsManager; Integrated Security=True\");
    }

    public DbSet<Product> Products { get; set; }
}