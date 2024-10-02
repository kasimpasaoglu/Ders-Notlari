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


#endregion