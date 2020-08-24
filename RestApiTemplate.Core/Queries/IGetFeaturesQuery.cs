using System.Linq;
using RestApiTemplate.Core.Dto;

namespace RestApiTemplate.Core.Queries
{
    public interface IGetFeaturesQuery : IQuery
    {
        IQueryable<FeatureDto> Execute();
    }
}