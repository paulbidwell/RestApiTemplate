using System.Text.Json;
using System.Web;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RestApiTemplate.Filters
{
    public class PaginationHttpHeaderFilter : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            //var request = context.HttpContext.Request;

            //var urlQueryString = HttpUtility.ParseQueryString(request.QueryString.ToString());

            //if (urlQueryString.Count > 0 && context.HttpContext.Items["Pagination"] is Pagination paginationData)
            //{
            //    var baseUrl = $"{request.Scheme}://{request.Host}{request.Path}";

            //    var currentPageNumber = paginationData.PageNumber;
            //    var maxPages = paginationData.TotalPages;
            //    var prevPageNumber = currentPageNumber - 1;
            //    var nextPageNumber = currentPageNumber + 1;

            //    urlQueryString.Set("page", currentPageNumber > 1 ? prevPageNumber.ToString() : "");
            //    var prevPageQueryString = urlQueryString.ToString();

            //    urlQueryString.Set("page", nextPageNumber <= maxPages ? nextPageNumber.ToString() : "");
            //    var nextPageQueryString = urlQueryString.ToString();

            //    paginationData.PrevPage = currentPageNumber > 1 ? $"{baseUrl}?{prevPageQueryString}" : null;
            //    paginationData.NextPage = nextPageNumber <= maxPages ? $"{baseUrl}?{nextPageQueryString}" : null;

            //    context.HttpContext.Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(paginationData));
            //}
        }

        public void OnResultExecuted(ResultExecutedContext context)
        { }
    }
}