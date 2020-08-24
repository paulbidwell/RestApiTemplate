using System.Linq;
using RestApiTemplate.Core.Dto;

namespace RestApiTemplate.Core.Queries
{
    public interface IGetCategoriesQuery : IQuery
    {
        IQueryable<CategoryDto> Execute();
    }
}