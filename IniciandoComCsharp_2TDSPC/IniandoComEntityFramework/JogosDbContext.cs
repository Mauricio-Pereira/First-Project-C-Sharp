using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace IniandoComEntityFramework;

public class JogosDbContext: DbContext
{
    public JogosDbContext() : base() {
    }
    
    public DbSet<Jogos> JOGOS { get; set; }
    public DbSet<Dlc> DLC { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        

        optionsBuilder.UseOracle(configuration.GetConnectionString("FiapOracleConnection"));
    }
    
}