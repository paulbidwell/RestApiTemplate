using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApiTemplate.Core.Domain;

namespace RestApiTemplate.Infrastructure.Configurations
{
    public class CategorySeedConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { CategoryId = 1, CategoryName = "Games" },
                new Category { CategoryId = 2, CategoryName = "Heroes" },
                new Category { CategoryId = 3, CategoryName = "Movies" },
                new Category { CategoryId = 4, CategoryName = "Television" },
                new Category { CategoryId = 5, CategoryName = "Other" });
        }
    }
}