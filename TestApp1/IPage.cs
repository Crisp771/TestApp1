namespace TestAppData
{
    public interface IPage
    {
        int PageID { get; set; }
        string Title { get; set; }
        string PageContent { get; set; }
    }
}