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

---

# Unit of Work

Bir tasarim desenidir.

- Unit of work veritabani islemlerinden sorumludur
- Tum veritabani islemlerini tek bir noktadan yonetmek icin kullanilir
- Veritabani ile birlikte transaction yonetimi yapilmalidir.
  - ornegin 2-3 tablodan olusan bir insert yapilacak
  - Yani kayit islemi iki tabloya veri insert yapilmasi gerekecek
  - Iki tablodan herhangi birinde basarisiz olursa, veri butunlugu bozulmus olacaktir.
- Transaction yonetiminde bunu takip edip basarisiz olan islemi iptal etmemiz gerekir.
- Unit of Work bu konuda yardimci olan bir tasarim desenidir

- Ayrica bagimliligi azaltir
  - Biz service'ten repoya gidiyoruz,
  - Ancak unit of work kullanilirsa, service'ten unit of worke gidecegiz
- Unit Of Work katmani repolari kapsulleyen bir katmandir
- Servisler repolarak direk erismez, unit of work uzerinden erisirler

## Yapisi

- UnitOfWork katmaninda yeni bir sinif olusturacagiz

1. Interface icinde kullanilacak veritabani ve repositorylerin hepsi tanimlanir
    - Interface **IDisposable** interface'inden kalitilir

```C#
public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Yazar> Author { get; }
    IGenericRepository<Kitap> Book { get; }

    Task<int> SaveChange();
}
```

2. Sinif olusturulurken kullanilacak repolar ctor icinde  new'lenir

```C#
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
```

3. Artik servis katmaninda repoya dogrudan erisim girmeyip, UnitOfWork classi uzerinden erisim saglayacagiz

```C#
public class BookService : IBookService
{
    private IUnitOfWork _unitOfWork;
    
    public BookService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }


    public List<Kitap> Get()
    {
        return _unitOfWork.Book.GetAll().Result.ToList();
    }
}

public interface IBookService
{
    public List<Kitap> Get();
}
```

---

# Generic Repo icinde yazdigimiz Expression ile calisan metod

Repo icinde yazdigimiz asagidaki metodu kullanalim

```C#
public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
    {
        return await _dbSet.Where(predicate).ToListAsync();
    }
```

- Bu metod parametre olarak expression alacagi icin, gelen kitap degerini expression haline getirip metoda parametre olarak gondermemiz gerekiyor

```C#
    public async Task<IEnumerable<Kitap>> Find(Kitap kitap)
    {
        // generic repo find adiminda expression istiyor, parametre olarak gelen kitap adi degerini expression haline getirelim
        Expression<Func<Kitap, bool>> filter = s => s.Ad == kitap.Ad;
        return await _unitOfWork.Book.Find(filter);
    }
```

- Controller'da kullanimi

```C#
    [Route("find")]
    public IActionResult Find(Kitap model)
    {
        var result = _bookService.Find(new Kitap() { Ad = model.Ad }).Result.ToList();
        return Ok(result);
    }
```

- :warning: **ODEV** Bu find metodunu modelin icinde hangi alanlarin olup olmadigina bakip olan alanlari expression ile esleyerek yapacak sekilde dinamik hale getir. (REFLECTION KULLAN)

# Reflection

```C#
Kitap k = new Kitap();
k.Ad = "Sefiller";
k.Yazar = "Victor Hugo";

// Reflection ile , yukarıdaki sınıfın içerisindeki propların değerlerini okuyalım!!

var props = k.GetType().GetProperties();
foreach (var prop in props)
{
    // reflection ile bir sınıf içerisindeki prop'un değeri okunabilir!!
    var value = prop.GetValue(k);
    Console.WriteLine("Name : {0} Value : {1}", prop.Name, value);

}
```

- Cozum

```C#
public async Task<IEnumerable<Kitap>> Find(KitapVM kitap)
{
    var props = kitap.GetType().GetProperties();    // gelen nesnenin propertylerini al.

    var parameter = Expression.Parameter(typeof(Kitap), "s"); // parameterExpression 's' olarak ver. ( s =>  ifadesi icindeki 's')

    Expression combinedExp = null; // olusturulacak expressionu dongu disinda tanima

    foreach (var prop in props)
    {
        var value = prop.GetValue(kitap); // value'yu yakala
        if (value == null || string.IsNullOrEmpty(value.ToString()))
        {
            continue;  // eger deger yoksa bu propu atla
        }

        var propAccess = Expression.Property(parameter, prop.Name);
        // Propery metodu ile, parametre('s' diye tanimladik) ile icinde gezdigimiz tipin property'si eslesti ( s.[PropAdi] )

        var constant = Expression.Constant(value);
        // bir sonraki adim da kullanilmak uzere; sorguda esitligin sag tarafinda kalan sabit degeri olusturur ( "Sefiller" )

        var equality = Expression.Equal(propAccess, constant);
        // Equal metodu ile az once propAccess ile olusturdumuz `s.[PropAdi]` ifadesinin devamina az once constant olarak olusturdugumuz degeri ekliyoruz
        // son hali -> ` s.[PropAdi] == [propun degeri] ` oldu...
        // mesela ad alani icin dusunursek: ``` s.Ad == "Sefiller" ``` gibi. 

        combinedExp = combinedExp == null ? equality : Expression.AndAlso(combinedExp, equality);
        // combinedExp null ise direk equality'i bas, null degilse `AndAlso()` metodu ile combinedExp'e equality'i ekle.
        // Mesela bir onceki dongude baska bir expression olusturulmussa ona yeni bir expression ilave edecek
        // mesela ad alani vardi kitapno alani da eklendi diyelim, cikti asagidaki gibi olacak
        // (s.Ad == "Sefiller") && (s.KitapNo == 15)
    }

    if (combinedExp == null) // eger bir filtre gelmediyse expression null kalacak. 
    {
        return await _unitOfWork.Book.Find(x => true); // butun kayitlari getir
    }

    // bu noktaya kadar olusturdugumuz aslinda bir Expression Tree'ydi. 
    // 'hangi kosullari kontrol edecegim?' sorusunun tanimidir.
    // Calistirilabilir bir lambda ifadesine cevirmek icin;
    var lambda = Expression.Lambda<Func<Kitap, bool>>(combinedExp, parameter);
    // artik expression `Func<Kitap, bool>` turunde, parametre olarak kitap alan ve bool donen bir lambda ifadesine donustu,  
    // yani ``` s => (s.Ad == "Sefiller") && (s.KitapNo == 15) ``` halini aldi
    
    return await _unitOfWork.Book.Find(lambda);

}
```
