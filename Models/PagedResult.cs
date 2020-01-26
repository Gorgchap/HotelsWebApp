namespace Models
{
    public class PagedResult<T>
    {
        public T[] Page { get; }
        public int PageCount { get; }
        public PagedResult(T[] page, int count) { Page = page; PageCount = count; }
    }
}
