using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestApiTemplate.Core.Dto;
using RestApiTemplate.Core.Queries;

namespace RestApiTemplate.Infrastructure.Queries
{
    public class GetFeaturesQuery : QueryBase<RestApiTemplateDbContext>, IGetFeaturesQuery
    {
        public GetFeaturesQuery(RestApiTemplateDbContext dbContext) : base(dbContext)
        { }

        public IQueryable<FeatureDto> Execute()
        {
            return DbContext.Features
                .AsNoTracking()
                .Select(f => new FeatureDto()
                {
                    FeatureId = f.FeatureId,
                    FeatureName = f.FeatureName
                });
        }
    }
}