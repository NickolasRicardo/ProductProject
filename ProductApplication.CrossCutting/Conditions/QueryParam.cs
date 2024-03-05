using ProductApplication.CrossCutting.Pagination;

namespace ProductApplication.CrossCutting.Conditions
{
    public class QueryParam: PagedParam
    {
        public string Filters { get; set; }
        public string Sort { get; set; }

    }
}
