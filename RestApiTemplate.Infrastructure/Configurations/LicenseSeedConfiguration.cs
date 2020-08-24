using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApiTemplate.Core.Domain;

namespace RestApiTemplate.Infrastructure.Configurations
{
    public class LicenseSeedConfiguration : IEntityTypeConfiguration<License>
    {
        public void Configure(EntityTypeBuilder<License> builder)
        {
            builder.HasData(
                new License { LicenseId = 1, LicenseName = "DC" },
                new License { LicenseId = 2, LicenseName = "Marvel"},
                new License { LicenseId = 3, LicenseName = "Mr Robot" },
                new License { LicenseId = 4, LicenseName = "Star Wars"});
        }
    }
}