using Microsoft.AspNetCore.Mvc;

namespace RestApiTemplate.Filters
{
    public class IsValidAttribute : TypeFilterAttribute
    {
        public IsValidAttribute() : base(typeof(IsValidHttpHeaderFilter))
        { }
    }
}