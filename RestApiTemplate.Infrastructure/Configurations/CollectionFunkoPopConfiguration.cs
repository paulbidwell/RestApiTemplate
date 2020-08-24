using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApiTemplate.Core.Domain;

namespace RestApiTemplate.Infrastructure.Configurations
{
    public class CollectionFunkoPopConfiguration : IEntityTypeConfiguration<CollectionFunkoPop>
    {
        public void Configure(EntityTypeBuilder<CollectionFunkoPop> builder)
        {
            builder.HasKey(cf => new { cf.CollectionId, cf.FunkoPopId });

            builder.HasOne(cf => cf.Collection)
                .WithMany(c => c.CollectionFunkoPops)
                .HasForeignKey(cf => cf.CollectionId);

            builder.HasOne(cf => cf.FunkoPop)
                .WithMany(f => f.CollectionFunkoPops)
                .HasForeignKey(cf => cf.FunkoPopId);
        }
    }
}