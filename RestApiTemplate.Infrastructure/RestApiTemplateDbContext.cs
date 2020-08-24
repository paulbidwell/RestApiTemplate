using Microsoft.EntityFrameworkCore;
using RestApiTemplate.Core.Domain;
using RestApiTemplate.Infrastructure.Configurations;

namespace RestApiTemplate.Infrastructure
{
    public class RestApiTemplateDbContext : DbContext
    {
        public RestApiTemplateDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FunkoPop> FunkoPops { get; set; }
        public DbSet<License> Licenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entity.Name).ToTable(entity.ClrType.Name);
            }

            modelBuilder.ApplyConfiguration(new CollectionFunkoPopConfiguration());

            modelBuilder.ApplyConfiguration(new CategorySeedConfiguration());
            modelBuilder.ApplyConfiguration(new FeatureSeedConfiguration());
            modelBuilder.ApplyConfiguration(new LicenseSeedConfiguration());
        }
    }
}