using generic_repository_04.DMO;

public interface IAuthorService
{
    public List<Yazar> Get();
}
public class AuthorService : IAuthorService
{
    // private readonly IGenericRepository<Yazar> _authorRepo;
    // public AuthorService(IGenericRepository<Yazar> authorRepo)
    // {
    //     _authorRepo = authorRepo;
    // }
    // artik repoya UnitOf work uzerinden erisecegiz

    private IUnitOfWork _unitOfWork;
    public AuthorService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public List<Yazar> Get()
    {
        return _unitOfWork.Author.GetAll().Result.ToList();
    }
}
