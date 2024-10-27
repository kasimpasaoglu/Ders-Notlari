// dotnet new classlib komutu ile bir class liblary olusturduk
// exe ile dll arasindaki en onemli fark dll' de main metodu yoktur. bu yuzden dll dosyalari tek baslarina calistirilamazlar.
// zaten varolus amaclari baska uygulamalara yardimci olmaktir, calistirilmak degil.

namespace DLL_KodKutuphanesi;

public class Ogrenci
{

    public void Calis()
    {
        Console.WriteLine("Ogrenci Calisti");
    }
    public void Uyu()
    {
        Console.WriteLine("Ogrenci Uyudu");
    }
}

// kodlama bittikten sonra `dotnet build` komutu ile dll dosyasini olustururuz
