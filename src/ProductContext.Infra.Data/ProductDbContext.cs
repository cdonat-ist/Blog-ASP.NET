using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductContext.Domain.Entities;
using ProductContext.Infra.Data.Mappings;

namespace ProductContext.Infra.Data;

public class ProductDbContext : DbContext
{
	public string connectionString = "Server=localhost;Port=5432;User Id=boilerplate_cs_psql;Password=12qwaszx;Database=boilerplate_cs_psql_db;";
	
    public IConfigurationRoot Configuration { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<User> Users { get; set; }
	public DbSet<Role> Roles { get; set; }


	// public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { 
	// 	// this.connectionString = connectionString;
	// }

 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(connectionString: connectionString); 
        base.OnConfiguring(optionsBuilder);
    }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfiguration(new ProductMap());
	}
}

