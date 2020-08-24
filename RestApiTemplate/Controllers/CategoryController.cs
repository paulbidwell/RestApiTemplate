using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using RestApiTemplate.Core.Dto;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData.Routing;
using Microsoft.EntityFrameworkCore;
using RestApiTemplate.Core;
using RestApiTemplate.Core.Queries;

namespace RestApiTemplate.Controllers
{
    //[ApiController, ApiVersion("1.0", Deprecated = false)]
    //[Route("api/v{version:apiVersion}/[controller]")]
    public class CategoryController : ODataController
    {
        private readonly IQueryFactory _queryFactory;

        public CategoryController(IQueryFactory queryFactory)
        {
            _queryFactory = queryFactory;
        }

        [HttpGet]
        [EnableQuery]
        [ODataRoute("categories")]
        public ActionResult<IQueryable<CategoryDto>> GetAll()
        {
            var result = _queryFactory.ResolveQuery<IGetCategoriesQuery>().Execute();

            if (result != null)
            {
                return Ok(result);
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        [EnableQuery]
        public async Task<ActionResult<CategoryDto>> Get([FromRoute]int id)
        {
            var result = await _queryFactory.ResolveQuery<IGetCategoriesQuery>().Execute()
                .Where(c => c.CategoryId == id)
                .SingleOrDefaultAsync();

            if (result != null)
            {
                return Ok(result);
            }

            return NoContent();
        }
    }
}