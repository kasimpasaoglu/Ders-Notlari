
/*
List<int> degisken = new List<int>();
degisken.Add(1);
degisken.Add(10);


List<string> stringKolleksiyon = new List<string>();
stringKolleksiyon.Add("Ayse");
stringKolleksiyon.Add("Fatma");

List<Ogrenci> ogrenciKolleksiyon = new List<Ogrenci>();

ogrenciKolleksiyon.Add(new Ogrenci() { Id = 10, Name = "Ali" });
*/

List<Ogrenci> ogrenciler = new();

while (true)
{
    int input = Ogrenci.Menu();

    if (input == 1)
    {
        var name = Ogrenci.GetName();
        Ogrenci.AddStudent(name, ogrenciler);
    }
    else if (input == 2)
    {

    }
    else if (input == 3)
    {

    }
    else if (input == 4)
    {

    }
}