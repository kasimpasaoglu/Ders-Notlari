using System.Linq.Expressions;
using generic_repository_04.DMO;

public class BookService : IBookService
{
    // kitap icin ayri bir repository yazmadik. Bunun yerine generic repository yazdik
    // generic repo hangi tip icin kullanmak istediginizi siz secersiniz.
    // ben kitap icin sececegim

    // public BookService(IGenericRepository<Kitap> kitapRepo)
    // {
    //     _kitapRepo = kitapRepo;
    // }
    // artik repoya UnitOf work uzerinden erisecegiz

    private IUnitOfWork _unitOfWork;
    public BookService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public List<Kitap> Get()
    {
        return _unitOfWork.Book.GetAll().Result.ToList();
    }

    public async Task<IEnumerable<Kitap>> Find(Kitap kitap)
    {
        // generic repo find adiminda expression istiyor, parametre olarak gelen kitap adi degerini expression haline getirelim
        Expression<Func<Kitap, bool>> filter = s => s.Ad == kitap.Ad;
        return await _unitOfWork.Book.Find(filter);
    }

}

public interface IBookService
{
    public List<Kitap> Get();
    public Task<IEnumerable<Kitap>> Find(Kitap kitap);
}