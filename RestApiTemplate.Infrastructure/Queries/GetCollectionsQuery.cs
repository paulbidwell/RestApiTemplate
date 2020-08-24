using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestApiTemplate.Core.Dto;
using RestApiTemplate.Core.Queries;

namespace RestApiTemplate.Infrastructure.Queries
{
    public class GetCollectionsQuery : QueryBase<RestApiTemplateDbContext>, IGetCollectionsQuery
    {
        public GetCollectionsQuery(RestApiTemplateDbContext dbContext) : base(dbContext)
        { }

        public IQueryable<CollectionDto> Execute()
        {
            return DbContext.Collections
                .Include(f => f.CollectionFunkoPops)
                .AsNoTracking()
                .Select(c => new CollectionDto
                {
                    CollectionId = c.CollectionId,
                    CollectionName = c.CollectionName,
                    FunkoPopIds = c.CollectionFunkoPops.Select(f => f.FunkoPopId).ToList()
                });
        }
    }
}