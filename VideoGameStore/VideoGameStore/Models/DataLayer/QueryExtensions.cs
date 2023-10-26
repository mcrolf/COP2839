namespace VideoGameStore.Models
{
    /*
     * Helper class for Query Options
     */
    public static class QueryExtensions
    {
        public static IQueryable<T> PageBy<T>(this IQueryable<T> items,
           int pagenumber, int pagesize)
        {
            return items
                .Skip((pagenumber - 1) * pagesize)
                .Take(pagesize);
        }

    }
}
