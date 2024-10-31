

Dictionary<int, string> liste = new Dictionary<int, string>();


liste.Add(1, "Ahmet");
liste.Add(2, "Mehmet");
liste.Add(3, "Ayse");
liste.Add(4, "Fatma");
liste.Add(5, "Melek");


Dictionary<int, Ogrenci> ogrenciler = new Dictionary<int, Ogrenci>();

Ogrenci o = new Ogrenci();
o.id = 1;
o.name = "Banu";
ogrenciler.Add(1, o);
ogrenciler.Add(2, new Ogrenci() { id = 2, name = "Faruk" });


foreach (KeyValuePair<int, Ogrenci> item in ogrenciler)
{
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value.id);
    Console.WriteLine(item.Value.name);
}