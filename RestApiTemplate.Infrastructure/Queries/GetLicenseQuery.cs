using System.Linq;
using Microsoft.EntityFrameworkCore;
using RestApiTemplate.Core.Dto;
using RestApiTemplate.Core.Queries;

namespace RestApiTemplate.Infrastructure.Queries
{
    public class GetLicenseQuery : QueryBase<RestApiTemplateDbContext>, IGetLicenseQuery
    {
        public GetLicenseQuery(RestApiTemplateDbContext dbContext) : base(dbContext)
        { }

        public IQueryable<LicenseDto> Execute()
        {
            return DbContext.Licenses
                .AsNoTracking()
                .Select(l => new LicenseDto()
                {
                    LicenseId = l.LicenseId,
                    LicenseName = l.LicenseName
                });
        }
    }
}