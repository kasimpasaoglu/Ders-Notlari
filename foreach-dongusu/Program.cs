
#region ArrayList icinde donecek bir foreach dongusu olusturalim
/*
using System.Collections;

ArrayList list = new ArrayList();
list.Add("Istanbul");
list.Add("Ankara");
list.Add("Rize");
list.Add("Mugla");
list.Add("Izmir");
list.Add("Ordu");
list.Add("Agri");
list.Add("Antalya");
list.Add("Hatay");
list.Add("Maras");

foreach (object item in list)
{
    Console.WriteLine(item);
}
*/
#endregion

#region SortedList ile foreach kullanimi
/*
using System.Collections;

SortedList sortedList = new SortedList();

sortedList.Add(1, "Ankara");
sortedList.Add(2, "Istanbul");
sortedList.Add(3, "Izmir");

foreach (DictionaryEntry i in sortedList)
{
    Console.WriteLine(i.Key + " -- " + i.Value);
}
*/
#endregion

#region ogrenciden aldigimiz not sayisina gore, notlarin toplami ve ortalamasini ekrana yazalim
/*
using System.Collections;

Console.WriteLine("Kac Adet Not Girilecek");
var notes = new ArrayList(int.Parse(Console.ReadLine().Trim()));

for (int i = 0; i < notes.Capacity; i++)
{
    Console.WriteLine("{0}. Notu Giriniz", i + 1);
    notes.Add(int.Parse(Console.ReadLine().Trim()));
}

double total = 0;
var counter = 1;
foreach (int note in notes)
{
    Console.WriteLine("{0}. not => {1}", counter, note);
    counter++;
    total += note;
}
Console.WriteLine("Toplam => {0}", total);
Console.WriteLine("Ortalama => {0}", Math.Round(total / (counter - 1), 2));
*/
#endregion

#region foreach ile dizi icindede donebiliriz
/*
string[] teknoloji = { "HTML", "CSS", "JavaScript", "C#", "React", " Java", "TypeScript", " Rust", };

foreach (string tech in teknoloji)
{
    Console.WriteLine(tech);
}
*/
#endregion

#region int tipinde dizi icinde donelim
/*
int[] plakalar = { 01, 19, 48, 02, 81, 34, 35 };

foreach (int plaka in plakalar)
{
    Console.WriteLine("Plaka {0}", plaka);
}
*/
#endregion

#region random tipinde bir dizi icinde donme
/*
Random[] randoms = { new Random(), new Random(), new Random(), new Random(), new Random(), new Random(), };

foreach (Random rnd in randoms)
{
    Console.WriteLine(rnd.Next());
}
*/
/*
int[] randoms = {new Random().Next(), new Random().Next(), new Random().Next()};

foreach (int i in randoms)
{
    Console.WriteLine(i);
}
*/
#endregion

#region carpim tablosunu foreach ile yapiniz
/*
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


foreach (int i in numbers)
{
    foreach (int j in numbers)
    {
        Console.WriteLine("{0} x {1} => {2}", i, j, i * j);
    }
    Console.WriteLine("-------------------");
}
*/
#endregion