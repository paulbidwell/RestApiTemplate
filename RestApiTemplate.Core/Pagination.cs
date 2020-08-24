namespace RestApiTemplate.Core
{
    public class Pagination
    {
        public int TotalResults { get; set; }
        public int? TotalPages { get; set; }
        public string PrevPage { get; set; }
        public string NextPage { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
    }
}