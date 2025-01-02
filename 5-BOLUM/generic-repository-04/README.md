# Generic Repository

Yazilim gelistirme sirasinda **Repository Pattern** ile birlikte kullanilan bir tasarim modelidir.

- Repository Pattern, veri erisim mantigini bir katman icinde soyutlayarak, kodun test edilebilirligini ve yeniden kullanilabilirligini arttirir.
- **Generic Repository** ise bu tasarim desenini **generic** hale getirerek farkli tipler icin tekrar tekrar ayni kodu yazma gereksinimini ortadan kaldirir.
- Mesela bir Product ve bir category ve ya order gibi farkli siniflar icin ayri ayri repo yazmak yerine tek bir repo yazilip, butun siniflarin onu kullanmasini saglayabiliriz.

## Yapisi

1. Interface
    - Generic bir interface yazilir

    ```C#
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
    ```

    - `T` reponun uzerinde calisagaci veri tipini temsil eder, (orn; Product, Category vb.)

2. Class
    - Generic class yazilir.

    ```C#
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
    ```

3. Dependecy Injectionu yapilmasi
    - Olusturulan bu generic repository'i diger katmanlarda kullanabilmek icin `Program.cs` te Dependency Injection asagidaki sekilde yapilabilir

    ```C#
    builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
    ```

4. Generic Repo Kullanimi
   - Artik olusturulan bu repo farkli classlari ilgilendiren butun katmanlarda kullanilabilir. Ornegin Kitap sorgusu yapan service katmaninda asagidaki sekilde kullanilir

   ```C#
    public class BookService : IBookService
    {
        private IGenericRepository<Kitap> _kitapRepo;
        public BookService(IGenericRepository<Kitap> kitapRepo)
        {
            _kitapRepo = kitapRepo;
        }
        public List<Kitap> Get()
        {
            return _kitapRepo.GetAll().Result.ToList();
        }
    }
   ```

    - Kitap icin ayri bir repository yazmadik. Bunun yerine generic repository yazdik
    - Generic repo hangi tip icin kullanmak istediginizi repo'yu inject ederken belirttik `<Kitap>`
