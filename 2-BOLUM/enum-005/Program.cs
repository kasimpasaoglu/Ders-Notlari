
string pazartesi = HaftaninGunleri.Pazartesi.ToString();
Console.WriteLine(pazartesi);

int muhasebe = (int)Departmanlar.Muhasebe;

Console.WriteLine(CarBrands.Mercedes);

string[] enumSabitleri = typeof(Departmanlar).GetEnumNames();
foreach (string item in enumSabitleri)
{
    Departmanlar seciliDepartman = (Departmanlar)Enum.Parse(typeof(Departmanlar), item);
    short departmanId = (short)seciliDepartman;
    Console.WriteLine($"Departman Adi: {item} || Kodu: {departmanId}");
}

Sabit c = new Sabit("FirmaX");
Console.WriteLine(c.FirmaAdi);