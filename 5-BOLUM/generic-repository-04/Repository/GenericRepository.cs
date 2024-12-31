using System.Linq.Expressions;
using generic_repository_04.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

public interface IGenericRepository<T> where T : class
{
    // id degerine gore sonuc getir
    Task<T> GetById(int id);
    // tum kayitlari getirir
    Task<IEnumerable<T>> GetAll();
    // gonderilen expressiona gore istenilen veriler getirilir.
    Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
    // kayit ekleme
    Task Add(T entity);
    // guncelleme
    bool Update(T entity);
    // silme
    bool Delete(T entity);
}

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly LibraryContext _context;
    private readonly DbSet<T> _dbSet;
    public GenericRepository(LibraryContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }
    public async Task Add(T entity)
    {
        _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public bool Delete(T entity)
    {
        _dbSet.Remove(entity);
        var result = _context.SaveChanges();
        return result >= 1;
    }

    public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T> GetById(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public bool Update(T entity)
    {
        _dbSet.Update(entity);
        var result = _context.SaveChanges();
        return result >= 1;

    }
}