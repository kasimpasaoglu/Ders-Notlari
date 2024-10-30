public class Ogrenci
{
    public int Id { get; }
    public string Name { get; set; }
    public Ogrenci(string name)
    {
        Id = new Random().Next(1000, 2000);
        Name = name;
    }

    public static int Menu()
    {
        Console.WriteLine("1-Ogrenci Ekle");
        Console.WriteLine("2-Ogrenci Sil");
        Console.WriteLine("3-Ogrencileri Yazdir");
        Console.WriteLine("4-Cikis Yap");
        int input;
        while (!(int.TryParse(Console.ReadLine().Trim(), out input) && (input == 1 || input == 2 || input == 3 || input == 4)))
        {
            Console.WriteLine("Geçersiz Giriş, Tekrar Deneyiniz");
        }

        return input;
    }

    public static string GetName()
    {
        return Console.ReadLine().Trim();
    }
    public static void AddStudent(string name, List<Ogrenci> array)
    {
        Ogrenci ogr = new Ogrenci(name);
        array.Add(ogr);

    }
}