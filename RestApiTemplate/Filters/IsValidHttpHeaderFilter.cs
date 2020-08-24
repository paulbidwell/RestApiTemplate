using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RestApiTemplate.Filters
{
    public class IsValidHttpHeaderFilter : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            context.HttpContext.Response.ContentType = "application/json";

            if (context.ModelState.IsValid)
            {
                var result = (ObjectResult)context.Result;

                if (result.Value != null)
                {
                    context.HttpContext.Response.Headers.Add("X-IsValid", JsonSerializer.Serialize(true));
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.OK;
                }
                else
                {
                    context.HttpContext.Response.Headers.Add("X-IsValid", JsonSerializer.Serialize(false));
                    context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NoContent;
                }
            }
            else
            {
                context.HttpContext.Response.Headers.Add("X-IsValid", JsonSerializer.Serialize(false));
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            }
        }

        public void OnResultExecuted(ResultExecutedContext context)
        { }
    }
}