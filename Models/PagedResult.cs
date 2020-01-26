namespace Models
{
    public class PagedResult<T>
    {
        public int PageCount { get; set; }
        public T[] Page;
    }
}
