using Microsoft.EntityFrameworkCore;
using NZWalks.API.Model.Domain_Model;


namespace NZWalks.API.Data
{
    public class NZWalksDBContext : DbContext 
    {
        public NZWalksDBContext(DbContextOptions<NZWalksDBContext> dbContextOption) : base(dbContextOption) 
        {
                
        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }
    }
}
