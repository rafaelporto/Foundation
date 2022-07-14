using Microsoft.EntityFrameworkCore;

namespace Foundation.Web.Data
{
    public class FeatureFlagDbContext : DbContext
    {
        public DbSet<FeatureFlag> FeatureFlags { get; set; }

        public string DbPath { get; }

        public FeatureFlagDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "foundation.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FeatureFlagConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
