using System.Collections;

#region Kullanicinin belirttigi ADET kadar asal sayi olusturup, array'de tutalim. Kullanicinin istedigi siradaki sayiyi yazalim, tekrar etsin.
/*
static ArrayList PrimeNumberGenerator(int numberCount)
{
    ArrayList result = new();
    var counter = 0;
    for (int i = 2; i < int.MaxValue; i++)
    {
        if (counter == numberCount)
        {
            break;
        }
        else
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                result.Add(i);
                counter++;
            }
        }
    }
    result.TrimToSize();
    return result;
}

static void ShowNumber(int numberCount, int index)
{
    ArrayList numbers = PrimeNumberGenerator(numberCount);
    Console.WriteLine($"{index + 1}. Siradaki Sayi => {numbers[index]}");
}

Console.WriteLine("Kac Adet Asal Sayi Olusturulacak?");
var numberCount = int.Parse(Console.ReadLine().Trim());

Console.WriteLine($"Kacinci siradaki sayiyi gormek istersiniz (1-{numberCount})");
var indexToShow = int.Parse(Console.ReadLine().Trim()) - 1;

ShowNumber(numberCount, indexToShow);
*/
#endregion

#region Kutuphane uygulamasi
/*
SortedList books = new();
books.Add("Sefiller", "Victor Hugo");
books.Add("Savas ve Baris", "Lev Tolstoy");
books.Add("1984", "George Orwell");
books.Add("Hayvan Ciftligi", "George Orwell");
books.Add("Suc ve Ceza", "Fyodor Dostoyevski");
books.Add("Kurk Mantolu Madonna", "Sabahattin Ali");
books.Add("Bulbulu Oldurmek", "Harper Lee");
books.Add("Yuzyillik Yalnizlik", "Gabriel Garcia Marquez");
books.Add("Fahrenheit 451", "Ray Bradbury");
books.Add("Cavdar Tarlasinda Cocuklar", "J.D. Salinger");

SortedList takenBooks = new();

while (true)
{
    Console.WriteLine(" ");
    Console.WriteLine("ANA MENU");
    Console.WriteLine("1. Stoktaki & Odunc Alinmis Kitaplari Listele");
    Console.WriteLine("2. Kitap Odunc Al");
    Console.WriteLine("3. Kitap Iade Et");
    Console.WriteLine("4. Cikis");
    Console.WriteLine(" ");
    var input = Console.ReadLine().Trim();
    if (input == "1")
    {
        Console.WriteLine("Stoktaki Kitaplar");
        WriteList(books);
        Console.WriteLine();
        Console.WriteLine("Odunc Alinmis Kitaplar");
        WriteList(takenBooks);
    }
    else if (input == "2")
    {
        Console.WriteLine("Stoktaki Kitaplar:");
        WriteList(books);
        Console.WriteLine();
        Console.WriteLine("Odunc Almak Istediginiz Kitabin Sira Numarasini Giriniz:");
        var index = int.Parse(Console.ReadLine().Trim()) - 1;
        MoveBook(books, index, takenBooks);
    }
    else if (input == "3")
    {
        Console.WriteLine("Odunc Alinmis Kitaplar:");
        WriteList(takenBooks);
        Console.WriteLine();
        Console.WriteLine("Iade Etmek Istediginiz Kitabin Sira Numarasini Giriniz:");
        var index = int.Parse(Console.ReadLine().Trim()) - 1;
        MoveBook(takenBooks, index, books);
    }
    else if (input == "4")
    {
        break;
    }
    else Console.WriteLine("Lutfen Gecerli Bir Secim Yapin");

}


static void WriteList(SortedList list)
{
    var i = 1;
    Console.WriteLine($"{"SIRA",5}. {"KITAP ADI",-26} || {"YAZAR ADI",-20}");
    foreach (DictionaryEntry book in list)
    {
        Console.WriteLine($"{i,5}. {book.Key,-26} || {book.Value,-20}");
        i++;
    }
}

static void MoveBook(SortedList sourceList, int indexOfBook, SortedList targetList)
{
    Console.WriteLine($"Kitap => {sourceList.GetKey(indexOfBook)} || {sourceList.GetByIndex(indexOfBook)}"); // islem yapilacak kitabi yazdirdik
    targetList.Add(sourceList.GetKey(indexOfBook), sourceList.GetByIndex(indexOfBook)); // kitabi kaynak listeden silmeden once, hedef listeye ekledik
    sourceList.RemoveAt(indexOfBook); // kitabi kaynak arrayden cikardik
}
*/
#endregion

#region Sinif Ogrenci Listesi Olusturma, Not, Ad, Soyad, Ogrenci Numarasi, Yas bilgilerini tutacak array.
/*
SortedList list = new();

Console.WriteLine("Sinif Mevcudunu Giriniz:");
var studentsCount = int.Parse(Console.ReadLine().Trim());

AddToList(list, studentsCount);

Menu(list);

static void Menu(SortedList list)
{
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("1 - Ogrenci Listesini Gor");
        Console.WriteLine("2 - Yeni Ogrenci Ekle");
        Console.WriteLine("3 - Cikis");
        Console.WriteLine();

        var input = Console.ReadLine().Trim();
        if (input == "1")
        {
            PrintList(list);
        }
        if (input == "2")
        {
            AddToList(list);
        }
        if (input == "3")
        {
            break;
        }
    }
}

static void AddToList(SortedList list, int count = 1)
{
    Console.WriteLine("Bilgileri Arada Bir Bosluk Birakarak Giriniz");
    Console.WriteLine("Isim - Soyisim - NotOrtalamasi - Yas");
    for (int i = 0; i < count; i++)
    {
        AddStudent(list);
    }
    Console.WriteLine("Kayit Islemi Tamamlandi");
}

static void AddStudent(SortedList list)
{
    string[] info = Console.ReadLine().Trim().Split(' ');
    var rnd = new Random();
    list.Add(rnd.Next(1000, 2000), info);
    Console.WriteLine($"{info[0]} {info[1]} eklendi.");
}

static void PrintList(SortedList list)
{
    Console.WriteLine($"{"NO",4} || {"Ad",-10} || {"Soyad",-10} || {"Not",3} || {"Yas",2}");
    foreach (DictionaryEntry item in list)
    {
        string[] details = (string[])item.Value;
        Console.WriteLine($"{item.Key,4} || {details[0],-10} || {details[1],-10} || {details[2],3} || {details[3],2}");
    }
}
*/
#endregion

#region Market Sepeti Simulasyonu
/*
SortedList products = new SortedList();
SortedList chart = new SortedList();
FillProducts(products);

while (true)
{
    WriteProducts(products);

    Console.WriteLine("Sepetinize Urun Eklemek icin arada bir bosluk birakarak sira ve adet giriniz");
    Console.WriteLine("Alisverisi Bitirmek ve Sepeti Gormek Icin 'exit' yaziniz");
    string[] input = Console.ReadLine().Trim().Split(' ');
    if (input[0] != "exit")
    {
        AddToChart(products, int.Parse(input[0]) - 1, chart, int.Parse(input[1]));
    }
    else
    {
        Console.WriteLine("Sepetiniz:");
        Console.WriteLine($"{"Urun",10} || {"Br. Fiyat",11} || {"Adet",8} || {"Toplam",8}");
        WriteChart(chart);
        Console.WriteLine("Toplam Tutar => {0} TL", SumChart(chart));
        break;
    }
}

static double SumChart(SortedList chart)
{
    double total = 0;
    foreach (DictionaryEntry item in chart)
    {
        double[] detail = (double[])item.Value;
        total += detail[2];
    }
    return Math.Round(total, 2);
}

static void AddToChart(SortedList products, int index, SortedList chart, int count)
{
    var itemName = products.GetKey(index);
    var itemPrice = products.GetByIndex(index);
    double[] detail = { (double)itemPrice, count, (double)itemPrice * count };
    chart.Add(itemName, detail);
}

static void WriteProducts(SortedList products)
{
    var counter = 1;
    Console.WriteLine($"{"Sira",4}{"Urun",10} || {"Fiyat",5}");
    foreach (DictionaryEntry item in products)
    {
        Console.WriteLine($"{counter,4}{item.Key,10} || {item.Value,5}");
        System.Threading.Thread.Sleep(50);
        counter++;
    }
}

static void FillProducts(SortedList products)
{
    var keys = new ArrayList() { "Elma", "Armut", "Muz", "Uzum", "Cilek", "Sut", "Ekmek", "Peynir", "Yogurt", "Yumurta" };
    var values = new ArrayList() { 13.50, 13.75, 14.75, 12.98, 14.85, 16.15, 12.50, 14.95, 12.70, 12.45 };
    for (int i = 0; i < keys.Count; i++)
    {
        products.Add(keys[i], values[i]);
    }
}

static void WriteChart(SortedList chart)
{
    foreach (DictionaryEntry item in chart)
    {
        double[] detail = (double[])item.Value;
        double pricePerUnit = detail[0];
        double unitCount = detail[1];
        double totalUnitPrice = detail[2];
        var name = item.Key;

        Console.WriteLine($"{name,10} || {pricePerUnit,9}tl || {unitCount,4} adet || {totalUnitPrice,6}tl");
    }
}
*/
#endregion

#region Randevu sistemi olusturma
/*
SortedList appointments = new();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("ANA MENU");
    Console.WriteLine("1. Randevu Ekle");
    Console.WriteLine("2. Randevu Cikar");
    Console.WriteLine("3. Randevulari Goster");
    Console.WriteLine("4. Cikis");
    Console.WriteLine();
    var input = Console.ReadLine().Trim();

    if (input == "1")
    {
        AddAppointment(appointments);
    }
    else if (input == "2")
    {
        RemoveAppointment(appointments);
    }
    else if (input == "3")
    {
        ShowAppointments(appointments);
    }
    else if (input == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Gecersiz Secim");
    }
}

static void AddAppointment(SortedList list)
{
    var rnd = new Random();
    var code = rnd.Next(100, 200).ToString();

    Console.WriteLine("Tarih Saat Giriniz (dd.mm.yyyy HH:MM)");
    DateTime key = DateTime.Parse(Console.ReadLine());

    Console.WriteLine("Aciklama Giriniz");
    var info = Console.ReadLine().Trim();

    string[] value = { info, code };
    list.Add(key, value);
}

static void RemoveAppointment(SortedList list)
{
    Console.WriteLine("Randevu Kodunu Giriniz");
    var code = int.Parse(Console.ReadLine().Trim());

    foreach (DictionaryEntry item in list)
    {
        string[] value = (string[])item.Value;

        if (int.Parse(value[1]) == code)
        {
            Console.WriteLine($"{item.Key} Tarihli / {value[0]} Randevunuz Silindi");

            list.Remove(item.Key);
            break;
        }
    }

}

static void ShowAppointments(SortedList list)
{
    Console.WriteLine($"{"Kod",5} || {"Tarih",20} || {"Aciklama",20}");
    foreach (DictionaryEntry item in list)
    {
        DateTime time = DateTime.Parse(item.Key.ToString());
        string[] value = (string[])item.Value;
        var code = value[1];
        var info = value[0];
        Console.WriteLine($"{code,5} || {time,20} || {info,20}");
    }
}
*/
#endregion

#region 

#endregion
