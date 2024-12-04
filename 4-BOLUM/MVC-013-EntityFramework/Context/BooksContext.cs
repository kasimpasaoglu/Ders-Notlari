using Microsoft.EntityFrameworkCore;

// DB olusturalim
// BooksDBContext bizim database'imizdir
// Bir sinifin database olmasi icin DbContext isimli siniftan kalitim almasi gerekir.
public class BooksDBContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public BooksDBContext(DbContextOptions<BooksDBContext> options) : base(options)
    {
    }
}