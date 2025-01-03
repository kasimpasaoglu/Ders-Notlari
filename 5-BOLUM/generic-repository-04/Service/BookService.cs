using System.Linq.Expressions;
using generic_repository_04.DMO;
using Microsoft.IdentityModel.Tokens;

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

    public async Task<IEnumerable<Kitap>> Find(KitapVM kitap)
    {

        var kitapDMO = new Kitap()
        {
            Kitapno = kitap.Kitapno,
            Ad = kitap.Ad,
            Puan = kitap.Puan,
            Sayfasayisi = kitap.Sayfasayisi,
            Turno = kitap.Turno,
            Yazarno = kitap.Yazarno,
            Islems = null,
        };

        var expression = ExpressionHelper.ExpressionMaker<Kitap>(kitapDMO);

        return await _unitOfWork.Book.Find(expression);

    }

}

public interface IBookService
{
    public List<Kitap> Get();
    public Task<IEnumerable<Kitap>> Find(KitapVM kitap);
}