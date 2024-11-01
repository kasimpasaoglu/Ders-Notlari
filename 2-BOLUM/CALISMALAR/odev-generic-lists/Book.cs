public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int PublicationYear { get; set; }
    public bool IsAvailable { get; set; }



    public Book() { }
    public Book(string title, string author, string genre, int publicationYear, bool isAvailable = true)
    {
        Id = BookHelper.FindNewId();
        Title = title;
        Author = author;
        Genre = genre;
        PublicationYear = publicationYear;
        IsAvailable = isAvailable;

    }
}