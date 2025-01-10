public class BookRepository
{
    private static readonly List<Book> Books = new List<Book>
    {
        new Book(){ Id= 1, Title= "1984", Author="Georde Orwell"},
        new Book(){ Id= 2, Title= "Brave new World", Author="Aldous Nuxley"},
        new Book(){ Id= 3, Title= "The Great Gatby", Author="F. Scott"},
    };


    public async Task<List<Book>> GetBookAsync()
    {
        // islemi bilincli olarak agirlastirmak icin
        await Task.Delay(5000);
        return Books;
    }
}