using Microsoft.EntityFrameworkCore;

namespace ProductsManager.Data;

public class DataBaseContext : DbContext
{
    public DataBaseContext(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=ProductsManager; Integrated Security=True\");
    }

    //public DbSet<Product> Products { get; set; }
}