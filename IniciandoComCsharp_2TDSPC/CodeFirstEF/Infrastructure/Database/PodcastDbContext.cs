using CodeFirstEF.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Infrastructure.Database;

    public class PodcastDbContext : DbContext
    {
        public virtual DbSet<Podcast> Podcasts { get; set; }
        public virtual DbSet<Episode> Episodes { get; set; }

        public PodcastDbContext(DbContextOptions<PodcastDbContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                
        }
    }
    
    
    