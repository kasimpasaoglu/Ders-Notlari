using calisma.DMO;

public class BooksService : IBooksService
{
    private IBooksRepo _repo;
    public BooksService(IBooksRepo repo)
    {
        _repo = repo;
    }
    public List<KitapDTO> GetAllBooks()
    {
        return _repo.GetAllBooks().OrderBy(x => x.Sayfasayisi).ToList();
    }

    public List<TurDTO> GetCategories()
    {
        return _repo.GetCategories();
    }

    public List<KitapDTO> GetBooksByCatId(int categoryId)
    {
        return _repo.GetBooksByCategoryId(categoryId);
    }


}

public interface IBooksService
{
    public List<KitapDTO> GetAllBooks();
    public List<TurDTO> GetCategories();
    public List<KitapDTO> GetBooksByCatId(int categoryId);

}