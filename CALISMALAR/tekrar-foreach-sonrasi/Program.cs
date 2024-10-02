#region Sayi tahmin oyunu
/*
using System.Collections;

var rnd = new Random();

var answers = new ArrayList(10);

var success = new ArrayList();
var fail = new ArrayList();

var guesses = 1;

for (int i = 0; i < answers.Capacity; i++)
{
    answers.Add(rnd.Next(0, 20));
}

Console.WriteLine("Rasgele {0} adet sayi olusturuldu (1=100 arasi). 5 Tahmin Hakkiniz Var", answers.Count);

foreach (var number in answers)
{
    if (guesses > 5)
    {
        Console.WriteLine("Tahmin Hakkiniz Kalmadi");
        Console.WriteLine("Dogru Tahminler");
        foreach (var answer in success)
        {
            Console.Write("-{0}-", answer);
        }
        Console.WriteLine("-------------------");

        Console.WriteLine("Yanlis Tahminler");
        foreach (var answer in fail)
        {
            Console.Write("-{0}-", answer);
        }
        break;
    }

    Console.WriteLine("{0}. Tahmininizi Girin", guesses);
    var input = int.Parse(Console.ReadLine().Trim());

    if (answers.Contains(input))
    {
        Console.WriteLine("{0} Sayisi Dogru Tahmin", input);
        success.Add(input);
    }
    else
    {
        Console.WriteLine("{0} Sayisi Yanlis Tahmin", input);
        fail.Add(input);
        guesses++;
    }
}
*/
#endregion

#region Carpim Tablosu
/*
int[] sol = new int[9];
int[] sag = new int[10];

for (var i = 0; i < 9; i++)
{
    sol[i] = i + 1;
}
for (var i = 0; i < 10; i++)
{
    sag[i] = i + 1;
}

foreach (int i in sol)
{
    foreach (int j in sag)
    {
        Console.WriteLine("{0} x {1} => {2}", i, j, i * j);
    }
    Console.WriteLine("---------");
}
*/
#endregion

#region Ogrenci Notlari 
/*
using System.Collections;
Random rnd = new Random();

Console.WriteLine("Ogrenci Sayisi Giriniz: ");
SortedList studens = new SortedList(int.Parse(Console.ReadLine().Trim()));

Console.WriteLine("Gecme Notunu Giriniz (0-100) :");
var noteToPass = int.Parse(Console.ReadLine().Trim());

for (int i = 0; i < studens.Capacity; i++)
{
    Console.WriteLine($"{i + 1}. Ogrencinin Adini Giriniz");
    var name = Console.ReadLine().Trim();
    var note = rnd.Next(0, 101);
    while (studens.ContainsKey(note))
    {
        note = rnd.Next(0, 101);
    }
    studens.Add(note, name);
}
var count = 0;
double total = 0;
foreach (DictionaryEntry i in studens)
{
    count++;
    if ((int)i.Key >= noteToPass)
    {
        Console.Write($"ISIM: {i.Value,8} ||  NOT : {i.Key,3} || GECTI");
        if (count > studens.Count - 4)
        {
            Console.Write(" || USTUN BASARI");
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"ISIM: {i.Value,8} ||  NOT : {i.Key,3} || KALDI");
    }
    total += (int)i.Key;
}
Console.WriteLine("Sinifin Not Ortalamasi => {0}", Math.Round(total / studens.Count, 2));
*/
#endregion

#region Kutuphane Uygulamasi
/*
using System.Collections;

SortedList books = new SortedList();
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

SortedList booksTaken = new SortedList();

while (true)
{
    Console.WriteLine(" ");
    Console.WriteLine("ANA MENU");
    Console.WriteLine("1. Stoktaki Kitaplari Listele");
    Console.WriteLine("2. Kitap Odunc Al");
    Console.WriteLine("3. Kitap Iade Et");
    Console.WriteLine("4. Cikis");
    Console.WriteLine(" ");

    var input = Console.ReadLine().Trim();
    if (input == "1")
    {
        var index = 0;
        Console.WriteLine($"{"SIRA",5}. {"KITAP ADI",-26} || {"YAZAR ADI",-20}");
        foreach (DictionaryEntry book in books)
        {
            Console.WriteLine($"{index + 1,5}. {book.Key,-26} || {book.Value,-20}");
            index++;
        }
    }
    else if (input == "2")
    {
        Console.WriteLine($"Almak istediginiz Kitabin Sira Numarasini Giriniz (1-{books.Count})");
        var index = int.Parse(Console.ReadLine().Trim()) - 1;
        while (index < 0 || index >= books.Count)
        {
            Console.WriteLine($"Lutfen Gecerli Bir Sira Numarasi Giriniz -> (1-{books.Count})");
            index = int.Parse(Console.ReadLine().Trim()) - 1;
        }
        Console.WriteLine($"Alinan Kitap => {books.GetKey(index)} || {books.GetByIndex(index)}");
        booksTaken.Add(books.GetKey(index), books.GetByIndex(index));
        books.RemoveAt(index);
    }
    else if (input == "3")
    {
        Console.WriteLine(" ");
        Console.WriteLine("ODUNC ALINMIS KITAPLAR:");
        var index = 0;
        Console.WriteLine($"{"SIRA",5}. {"KITAP ADI",-26} || {"YAZAR ADI",-20}");
        foreach (DictionaryEntry book in booksTaken)
        {
            Console.WriteLine($"{index + 1,5}. {book.Key,-26} || {book.Value,-20}");
            index++;
        }
        Console.WriteLine(" ");
        Console.WriteLine($"Iade etmek istediginiz kitabin sira numarasini giriniz (1-{booksTaken.Count})");
        index = int.Parse(Console.ReadLine().Trim()) - 1;
        while (index < 0 || index >= booksTaken.Count)
        {
            Console.WriteLine($"Lutfen Gecerli Bir Sira Numarasi Giriniz -> (1-{booksTaken.Count})");
            index = int.Parse(Console.ReadLine().Trim()) - 1;
        }
        Console.WriteLine($"Iade Edilen Kitap => {booksTaken.GetKey(index)} || {booksTaken.GetByIndex(index)}");
        books.Add(booksTaken.GetKey(index), booksTaken.GetByIndex(index));
        booksTaken.RemoveAt(index);

    }
    else if (input == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Lutfen Gecerli Bir Secim Yapiniz");
    }
}
*/
#endregion

#region Asal Sayi 
/*
using System.Collections;

Console.WriteLine("Kac Adet Asal Sayi Uretilsin?");
var numbersCount = int.Parse(Console.ReadLine().Trim());

Queue primeNumbers = new();
Stack primeNumbersStack = new();

var primeNumbersCount = 0;

for (int i = 2; i < int.MaxValue; i++)
{
    bool isPrime = true;

    for (int j = 2; j <= Math.Sqrt(i); j++) // daha verimli olmasi icin sadece karekokune kadar olan sayilara bolunup bolunmedigine bakmak yeterli
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }

    }
    if (isPrime)
    {
        primeNumbersCount++;
        primeNumbers.Enqueue(i);
        primeNumbersStack.Push(i);
    }
    if (primeNumbersCount == numbersCount)
    {
        break;
    }
}
Console.WriteLine($"{primeNumbers.Count} Adet Sayi Olusturuldu");

Console.WriteLine("Buyukten Kucuge Yazdirmak icin '1' || Kucukten Buyuge Dogru Yazdirmak Icin '2' giriniz:");
var reversePick = int.Parse(Console.ReadLine().Trim());
while (reversePick != 1 && reversePick != 2)
{
    Console.WriteLine("Lutfen Gecerli Bir Secim Yapiniz (1 / 2)");
    reversePick = int.Parse(Console.ReadLine().Trim());
}


while (primeNumbers.Count > 0)
{
    Console.WriteLine("Siradaki Asal Sayiyi Gormek Icin Enter'a Basiniz, Cikmak Icin 'exit' yaziniz");
    var input = Console.ReadLine().ToLower().Trim();
    if (input == "exit")
    {
        break;
    }
    else
    {
        if (reversePick == 1)
        {
            Console.WriteLine($"{primeNumbersStack.Pop()}");
        }
        else if (reversePick == 2)
        {
            Console.WriteLine($"{primeNumbers.Dequeue()}");
        }
    }
}
*/
#endregion

#region Sayi dizisi islemleri

using System.Collections;

Console.WriteLine("Kac adet sayi girilecek");
var count = int.Parse(Console.ReadLine().Trim());

ArrayList numbers = new(count);
var biggestNumber = int.MinValue;
var smallestNumber = int.MaxValue;
double total = 0;

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{i + 1}. Sayiyi Giriniz");
    var input = int.Parse(Console.ReadLine().Trim());
    if (input > biggestNumber)
    {
        biggestNumber = input;
    }
    else if (input < smallestNumber)
    {
        smallestNumber = input;
    }
    numbers.Add(input);
    total += input;
}
numbers.TrimToSize();
Console.WriteLine("Sayi Girisi Tamamlandi");
Console.WriteLine($"En Buyuk Sayi => {biggestNumber}");
Console.WriteLine($"En En Kucuk Sayi => {smallestNumber}");
Console.WriteLine($"Ortalama => {Math.Round(total / numbers.Count, 2)}");
Console.WriteLine(" ");

var x = 1;
foreach (int number in numbers)
{
    Console.WriteLine($"{x,2} => {number,3}");
    x++;
}

#endregion