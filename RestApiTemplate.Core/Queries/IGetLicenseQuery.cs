using System.Linq;
using RestApiTemplate.Core.Dto;

namespace RestApiTemplate.Core.Queries
{
    public interface IGetLicenseQuery : IQuery
    {
        IQueryable<LicenseDto> Execute();
    }
}