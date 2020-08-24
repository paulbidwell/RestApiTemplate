using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestApiTemplate.Core.Dto;
using RestApiTemplate.Core.Queries;

namespace RestApiTemplate.Infrastructure.Queries
{
    public class GetFunkoPopsQuery : QueryBase<RestApiTemplateDbContext>, IGetFunkoPopsQuery
    {
        public GetFunkoPopsQuery(RestApiTemplateDbContext dbContext) : base(dbContext)
        { }

        public IQueryable<FunkoPopDto> Execute()
        {
            return DbContext.FunkoPops
                .Include(c => c.Category)
                .Include(f => f.Feature)
                .Include(l => l.License)
                .AsNoTracking()
                .Select(f => new FunkoPopDto
                {
                    FunkoPopId = f.FunkoPopId,
                    MoldNumber = f.MoldNumber,
                    Name = f.Name,
                    Year = f.Year,
                    Category = f.Category.CategoryName,
                    Feature = f.Feature.FeatureName,
                    License = f.License.LicenseName
                });
        }
    }
}