using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Oracle.EntityFrameworkCore;

namespace CP01_TEST;

public class SwCardsDbContext: DbContext
{
    public SwCardsDbContext() : base() {
    }
    public DbSet<SwCard> SWCARDS { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        optionsBuilder.UseOracle(configuration.GetConnectionString("FiapOracleConnection"), options =>
        {
            options.CommandTimeout(120); 
        });
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SwCard>()
            .Property(c => c.ID)
            .ValueGeneratedOnAdd();
    }
    
}