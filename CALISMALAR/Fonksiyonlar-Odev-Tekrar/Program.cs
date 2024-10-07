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

