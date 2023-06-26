using Microsoft.EntityFrameworkCore;
using ProductsManager.Data.Entities;

namespace ProductsManager.Data;

public class DataBaseContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=ProductsManager; Integrated Security=true;");
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<PriceListPosition> PriceListPositions { get; set; }
    public DbSet<PriceList> PriceLists { get; set; }
    public DbSet<CustomerType> CustomerTypes { get; set; }
    public DbSet<CustomerState> CustomerStates { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Currency> Currencies { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Product>().HasMany(x => x.PriceListPositions).WithOne(x => x.Product).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<PriceList>().HasMany(x => x.PriceListPositions).WithOne(x => x.PriceList).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Currency>().HasMany(x => x.PriceLists).WithOne(x => x.Currency).OnDelete(DeleteBehavior.Restrict);


        builder.Entity<PriceList>().HasMany(x => x.Customers).WithOne(x => x.PriceList).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Currency>().HasMany(x => x.Customers).WithOne(x => x.Currency).OnDelete(DeleteBehavior.Restrict);

        builder.Entity<CustomerType>().HasMany(x => x.Customers).WithOne(x => x.CustomeType);


        builder.Entity<Customer>().HasOne(x => x.PriceList).WithMany(x => x.Customers).OnDelete(DeleteBehavior.Restrict);
    }
}