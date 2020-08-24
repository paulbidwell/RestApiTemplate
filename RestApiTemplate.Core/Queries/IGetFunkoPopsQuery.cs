using System.Linq;
using RestApiTemplate.Core.Dto;

namespace RestApiTemplate.Core.Queries
{
    public interface IGetFunkoPopsQuery : IQuery
    {
        IQueryable<FunkoPopDto> Execute();
    }
}