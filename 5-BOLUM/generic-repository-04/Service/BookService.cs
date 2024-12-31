using generic_repository_04.DMO;

public class BookService : IBookService
{
    // kitap icin ayri bir repository yazmadik. Bunun yerine generic repository yazdik
    // generic repo hangi tip icin kullanmak istediginizi siz secersiniz.
    // ben kitap icin sececegim
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

public interface IBookService
{
    public List<Kitap> Get();
}