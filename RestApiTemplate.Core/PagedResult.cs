using System.Collections.Generic;

namespace RestApiTemplate.Core
{
    public class PagedResult<T> where T : class
    {
        public Pagination Pagination { get; set; }
        public List<T> Data { get; set; }
    }
}