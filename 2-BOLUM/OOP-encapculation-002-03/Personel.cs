public class Personel
{
    public int Id { get; set; }
    public string Isim { get; set; }
    public int Yas { get; private set; }
    public double Maas { get; }
    public string IsYeri { get; set; } = "Karabuk Demir Celik";
    public Personel(int id, string isim, int yas, string isYeri)
    {
        // ortamlarda eger otomatik prop varsa ctor icerisinden gelen degerler direk otomatik proplara maplenirler,
        // zaten otomatik prop kullaniliyorsa field yoktur. 
        Id = id;
        Isim = isim;
        Yas = yas;
        IsYeri = isYeri;
    }
}