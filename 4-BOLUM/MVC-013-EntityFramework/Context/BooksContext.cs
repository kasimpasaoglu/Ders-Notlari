using Microsoft.EntityFrameworkCore;

// DB olusturalim
public class BooksDBContext : DbContext
{
    // book isimli sinifi tablo olacak sekilde verelim

    public DbSet<Book> Books { get; set; }
    public BooksDBContext(DbContextOptions<BooksDBContext> options) : base(options)
    {


    }
}