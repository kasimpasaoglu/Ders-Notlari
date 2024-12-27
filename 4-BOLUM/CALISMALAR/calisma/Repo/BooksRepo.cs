using calisma.DataAccessLayer;
using calisma.DMO;
using Microsoft.EntityFrameworkCore;

public class BooksRepo : IBooksRepo
{
    private LibraryDb _context;
    public BooksRepo(LibraryDb context)
    {
        _context = context;
    }


    public List<KitapDTO> GetAllBooks()
    {
        var result = _context.Kitaps
        .Include(k => k.YazarnoNavigation)
        .Include(k => k.TurnoNavigation)
        .Select(x => new KitapDTO
        {
            Kitapno = x.Kitapno,
            Ad = x.Ad,
            Sayfasayisi = x.Sayfasayisi,
            YazarAd = x.YazarnoNavigation.Ad,
            YazarSoyad = x.YazarnoNavigation.Soyad,
            Tur = x.TurnoNavigation.Ad
        }).ToList();

        return result;
    }

    public List<TurDTO> GetCategories()
    {
        var result = _context.Turs.Select(x => new TurDTO
        {
            Ad = x.Ad,
            Turno = x.Turno
        }).ToList();
        return result;
    }

    public List<KitapDTO> GetBooksByCategoryId(int categoryId)
    {
        return _context.Kitaps
            .Where(x => x.Turno == categoryId) // parametre olarak gelen (dropdowndan secilen turno ile) esit olan satirlari al
            .Select(x => new KitapDTO
            {
                Kitapno = x.Kitapno,
                Ad = x.Ad,
                Sayfasayisi = x.Sayfasayisi,
                YazarAd = x.YazarnoNavigation.Ad,
                YazarSoyad = x.YazarnoNavigation.Soyad,
                Tur = x.TurnoNavigation.Ad
            }).ToList();

    }
}


public interface IBooksRepo
{
    public List<KitapDTO> GetAllBooks();
    public List<TurDTO> GetCategories();
    public List<KitapDTO> GetBooksByCategoryId(int categoryId);
}