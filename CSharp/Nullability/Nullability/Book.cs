namespace Nullability
{
    public class Book
    {
        public Book(string title, string? publisher = null, string? isbn = null)
        {
            Title = title;
            Publisher = publisher;
            Isbn = isbn;
        }
        public string Title { get; set; }
        public string? Publisher { get; set; }
        public string? Isbn { get; set; }
    }
}
