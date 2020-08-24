using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApiTemplate.Core.Domain;

namespace RestApiTemplate.Infrastructure.Configurations
{
    public class FeatureSeedConfiguration : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.HasData(
                new Feature { FeatureId = 1, FeatureName = "Chase"},
                new Feature { FeatureId = 2, FeatureName = "Colour Variant"},
                new Feature { FeatureId = 3, FeatureName = "Exclusive"},
                new Feature { FeatureId = 4, FeatureName = "Flocked"},
                new Feature { FeatureId = 5, FeatureName = "Glitter"},
                new Feature { FeatureId = 6, FeatureName = "Glow"},
                new Feature { FeatureId = 7, FeatureName = "Metallic"},
                new Feature { FeatureId = 8, FeatureName = "Multipack"},
                new Feature { FeatureId = 9, FeatureName = "Outfit Variant"},
                new Feature { FeatureId = 10, FeatureName = "Texture Variant"});
        }
    }
}