using System.Collections;

public static class Personel
{
    public static ArrayList Liste { get; set; }
}

// static classlarin icindeki butun uyelerin static olmasi gereklidir
// bunu sebebi, non-static bir ogeye erismek icin nesne ornegi alinmasi gerekmektedir. Ancak static siniflarda nesne ornegi alinamadigi icin, static siniflarda non-static bir oge yazilamaz.

public static class Personel2
{
    // this keyword'u static siniflar icin kullanilmaz
    // static ctorlar sadece bir kez calisir
    // static ctorlar parametre alamazlar, ve overloading yapilmaz. 
    public static int Maas { get; set; }
    static Personel2()
    {
        Maas = 100;
    }
    // static ctor icersiinde maas degiskeni bellege ciksin diye deger verildi.
}

public class Ogrenci
{
    // bir class icinde hem static hem non-static class yazilabilir.
    // static bir uye ile nonstatic uye arasindaki farki gormek icin, bu siniftan uretilen nesne sayilarini saklayan bir degisken yazalim, ve ctor her calistiginda bu degiskenleri 1 arttirsin
    public Ogrenci()
    {
        StaticNesneSayisi++;
        NonStaticNesneSayisi++;
    }
    static Ogrenci()
    {

    }
    public static int StaticNesneSayisi { get; set; }
    public int NonStaticNesneSayisi { get; set; }
    public void DersCalis()
    {
        Console.WriteLine("Ders Calisildi");
    }
    public static void OkulaGit()
    {
        Console.WriteLine("Okula Gidildi.");
    }
}

// static sinifin uyesidir,
// non-static nesnenin uyesidir.
// static tum nesneleri kapsar, cunku nesnelerden ustundur ve bagimzi hareket eder. 