using Microsoft.AspNetCore.Mvc;

namespace RestApiTemplate.Filters
{
    public class AddPaginationHttpHeaderAttribute : TypeFilterAttribute
    {
        public AddPaginationHttpHeaderAttribute() : base(typeof(PaginationHttpHeaderFilter))
        { }
    }
}
