using System.Collections;

public static class Personel
{
    public static ArrayList Liste { get; set; }
}

public static class Personel2
{

    public static int Maas { get; set; }
    static Personel2()
    {
        Maas = 100;
    }

}

public class Ogrenci
{

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