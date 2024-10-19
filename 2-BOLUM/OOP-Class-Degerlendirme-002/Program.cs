Ogrenci o = new Ogrenci();
Console.WriteLine($"ID => {o.Id} || Name => {o.Ad}");

Degistir(o);
Console.WriteLine($"ID => {o.Id} || Name => {o.Ad}");


static void Degistir(Ogrenci o)
{
    o.Id = 10;
    o.Ad = "Kemalettin";
}