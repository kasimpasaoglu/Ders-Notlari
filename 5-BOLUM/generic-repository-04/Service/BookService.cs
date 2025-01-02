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
        var props = kitap.GetType().GetProperties();
        var parameter = Expression.Parameter(typeof(Kitap), "s");
        Expression combinedExp = null;

        foreach (var prop in props)
        {
            var value = prop.GetValue(kitap);
            if (value == null || string.IsNullOrEmpty(value.ToString()))
            {
                continue;
            }

            var propAccess = Expression.Property(parameter, prop.Name);
            var constant = Expression.Constant(value);
            var equality = Expression.Equal(propAccess, constant);
            combinedExp = combinedExp == null ? equality : Expression.AndAlso(combinedExp, equality);
        }

        if (combinedExp == null)
        {
            return await _unitOfWork.Book.Find(x => true);
        }

        var lambda = Expression.Lambda<Func<Kitap, bool>>(combinedExp, parameter);
        return await _unitOfWork.Book.Find(lambda);

    }

}

public interface IBookService
{
    public List<Kitap> Get();
    public Task<IEnumerable<Kitap>> Find(KitapVM kitap);
}