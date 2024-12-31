using generic_repository_04.DMO;

public interface IAuthorService
{
    public List<Yazar> Get();
}
public class AuthorService : IAuthorService
{
    private readonly IGenericRepository<Yazar> _authorRepo;
    public AuthorService(IGenericRepository<Yazar> authorRepo)
    {
        _authorRepo = authorRepo;
    }
    public List<Yazar> Get()
    {
        return _authorRepo.GetAll().Result.ToList();
    }
}
