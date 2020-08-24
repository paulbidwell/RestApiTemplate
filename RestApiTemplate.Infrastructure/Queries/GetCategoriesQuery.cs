using RestApiTemplate.Core.Dto;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestApiTemplate.Core.Queries;

namespace RestApiTemplate.Infrastructure.Queries
{
    public class GetCategoriesQuery : QueryBase<RestApiTemplateDbContext>, IGetCategoriesQuery
    {
        public GetCategoriesQuery(RestApiTemplateDbContext dbContext) : base(dbContext)
        { }

        public IQueryable<CategoryDto> Execute()
        {
            return DbContext.Categories
                .AsNoTracking()
                .Select(c => new CategoryDto
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName
                });
        }
    }
}