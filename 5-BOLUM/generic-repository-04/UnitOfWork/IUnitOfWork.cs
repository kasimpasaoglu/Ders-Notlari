using generic_repository_04.DataAccessLayer;
using generic_repository_04.DMO;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Yazar> Author { get; }
    IGenericRepository<Kitap> Book { get; }

    Task<int> SaveChange();
}


public class UnitOfWork : IUnitOfWork
{

    // SaveChange() icinde context uzerinden savechange yapilacagi icin context'i DI ile almamiz lazim

    private LibraryContext _context;
    public IGenericRepository<Yazar> Author { get; }
    public IGenericRepository<Kitap> Book { get; }
    public UnitOfWork(LibraryContext context)
    {
        _context = context;
        Author = new GenericRepository<Yazar>(_context);
        Book = new GenericRepository<Kitap>(_context);

    }

    public async Task<int> SaveChange()
    {
        // unit of work uzerinden savechange yapacagiz
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}