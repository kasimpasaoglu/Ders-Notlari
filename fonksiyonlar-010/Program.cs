﻿#region syntax
/*
erisim belirteci + static / static degil + geri donus tipi / deger donmeyecekse void + metod adi (metod parametreleri){

}
*/
#endregion

#region parametre olarak aldigi degeri ters cevirip geri donduren bir metod yazalaim
/*
static string TersCevir(string deger)
{
    string ters = "";
    for (int i = deger.Length - 1; i >= 0; i--)
    {
        ters += deger[i];
    }
    return ters;
}


Console.WriteLine(TersCevir("Kasim"));
*/

#endregion

#region ders sonrasi
/*
static int Average(int number1, int number2, int number3, int number4)
{
    return (number1 + number2 + number3 + number4) / 4;
}

Console.WriteLine(Average(3, 5, 7, 9));
*/
#endregion

#region Parametre olarak iki tane int tipinde deger alan ve geriye int donen bir metod yaziniz. iki sayiyi toplayip degeri donsun
/*
static int Sum(int x, int y)
{
    return x + y;
}

Console.WriteLine(Sum(5, 97));
*/
#endregion

#region int tipinde yari cap degeri alip dairenin alanini hesaplayip geriye deger donen metodu yazin
/*
static double AreaOfCircle(double r)
{
    var area = Math.PI * Math.Pow(r, 2);
    return Math.Round(area, 2);
}
Console.WriteLine(AreaOfCircle(8));
*/
#endregion

#region iki tane int tipinde min ve max deger alan ve geriye random bir bir int donen metod yaziniz
/*
static int RandomGenerate(int min, int max)
{
    var rnd = new Random();
    return rnd.Next(min, max);
}
Console.WriteLine(RandomGenerate(10, 100));
*/
#endregion

#region disaridan gonderdigimiz deger ile PI sayisinin o sayi olan basamagini geri donduren metod
/*
static int IndexInPI(int digit)
{
    string piNumber = (Math.PI).ToString();
    return piNumber[digit];
}

Console.WriteLine(IndexInPI(15));
*/
#endregion

#region girmis oldugumuz yil degerine kac gun oldugunu soyleyen metod
/*
static double DaysTo(int year)
{
    DateTime userDate = new(year, 01, 01);
    DateTime now = DateTime.Now;

    TimeSpan diff = userDate - now;
    return Math.Floor(diff.TotalDays);
}
Console.WriteLine(DaysTo(2025));
*/
#endregion

#region girmis oldugumuz char degerinin int karsiligini verecek fonsiyon
/*
static int CharToInt(char letter)
{
    return Convert.ToInt32(letter);
}
Console.WriteLine(CharToInt('A'));
*/
#endregion

#region parametre olarak kullanici adi ve sifre alan kullanici dogrulama yapip, geriye ? donduren bir metod yaziniz. Metodtan bir kosul kurup giris basarili yazdiriniz.
/*
static bool CheckLogin(string userName, string pasword)
{
    var userNameDB = "wissen";
    var passwordDB = "besiktas123";
    // v1
    // if (userName == userNameDB && pasword == passwordDB)
    // {
    //     return true;
    // }
    // else
    // {
    //     return false;
    // }

    //v2 
    return userName == userNameDB && pasword == passwordDB;

}

Console.WriteLine("Kullanici Adinizi Giriniz");
var userNameInput = Console.ReadLine().ToLower().Trim();

Console.WriteLine("Sifrenizi Giriniz");
var passwordInput = Console.ReadLine().Trim();

if (CheckLogin(userNameInput, passwordInput))
{
    Console.WriteLine("Giris Basarili");
}
else
{
    Console.WriteLine("Giris Basarisiz");
}
*/

#endregion

#region Bir metoda ArrayList parametre alip Dizi donelim
/*
using System.Collections;


ArrayList names = new ArrayList();
names.Add("kasim");
names.Add("cansu");
names.Add("sahin");
names.Add("selcuk");
names.Add("ceylin");
names.Add("pelin");
names.Add("orhan");
names.Add("alp");
names.Add("ibrahim");
names.Add("ahmet");


static string[] FirstLatterToUpper(ArrayList list)
{
    //string dizisi alip bu dizinin icindeki degerlin bas harflerini buyuk yapip geri donemlim
    string[] ModdedArray = new string[list.Count];
    var i = 0;
    foreach (var item in list)
    {
        ModdedArray[i] = char.ToUpper(item.ToString()[0]) + item.ToString().Substring(1);
        i++;
    }
    return ModdedArray;
}

string[] namesModded = FirstLatterToUpper(names);
foreach (string name in namesModded)
{
    Console.WriteLine(name);
}
*/
#endregion

#region Parametre Alan ve geriye deger dondurmeyen metod dizi alip tersini ekrana yazdiran metod
/*
static void ReverseArray(string[] list)
{
    string[] reversed = new string[list.Length];
    var index = 0;
    for (int i = list.Length - 1; i >= 0; i--)
    {
        reversed[index] = list[i];
        index++;
    }
    foreach (var item in reversed)
    {
        Console.WriteLine(item);
    }
}

string[] names = { "kasim", "cansu", "sahin", "selcuk", "ceylin", "pelin", "orhan" };

ReverseArray(names);
*/
#endregion

#region kendi bas harf buyuk metodunu yazalaim, Parametre olarak string alan ve girilen stringin bas harfini buyuten bir metod yaziniz
/*
static void UpperFirstLetter(string item)
{
    var value = item[0].ToString().ToUpper();
    for (int i = 1; i < item.Length; i++)
    {
        value += item[i];
    }
    Console.WriteLine(value);
}
UpperFirstLetter("kasim");
*/
#endregion

#region kendi substring metonumuzu yazalim, bir string deger, bir baslangic degeri, bir uzunluk degeri alacak. MySubstring
/*
static void MySubstring(string item, int index, int lenght)
{
    var substring = "";
    for (int i = index; i < index + lenght; i++)
    {
        substring += item[i];
    }
    Console.WriteLine(substring);
}

MySubstring("0123456789", 5, 2);
*/
#endregion

#region geriye deger dondurmeyen 5 farkli metod yap.
//1. Arrayi siralayip ekrana yazdiran fonksiyon
// using System.Collections;

// static void SortAndPrintArray(ArrayList list)
// {
//     list.Sort();
//     var i = 1;
//     foreach (var item in list)
//     {
//         Console.WriteLine($"{i,3}. => {item}");
//         i++;
//     }
// }

// ArrayList names = new ArrayList();
// names.Add("kasim");
// names.Add("cansu");
// names.Add("sahin");
// names.Add("selcuk");
// names.Add("ceylin");
// names.Add("pelin");
// names.Add("orhan");
// names.Add("alp");
// names.Add("ibrahim");
// names.Add("ahmet");

// SortAndPrintArray(names);


// 2. Belirtilen adet kadar random sayi uretip ekrana yazan fonksiyon
// static void PrintRandomNumbers(int count)
// {
//     var rnd = new Random();
//     for (int i = 0; i < count; i++)
//     {
//         int number = rnd.Next(0, 100);
//         Console.WriteLine($"{i + 1,3}. => {number,3}");
//     }
// }

// PrintRandomNumbers(10);

// 3. girilen sayinin asal olup olmadigini ekrana yazan fonksiyon
// static void CheckIfPrime(int number)
// {
//     bool isPrime = true;

//     for (int i = 2; i < Math.Sqrt(number); i++)
//     {
//         if (number % i == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }

//     if (isPrime)
//     {
//         Console.WriteLine($"{number} is prime");
//     }
//     else
//     {
//         Console.WriteLine($"{number} is NOT prime");
//     }
// }

// CheckIfPrime(7);
// CheckIfPrime(8);

// 4. verilen int dizisindeki sayilari toplayip ortalamasini alan ve ekrana yazdiran fonksiyon
// using System.Collections;

// static void SumArray(ArrayList numberList)
// {
//     double total = 0;
//     double average = 0;

//     foreach (var number in numberList)
//     {
//         total += (int)number;
//     }
//     average = Math.Round(total / numberList.Count, 2);

//     Console.WriteLine($"Dizinin Toplami => {total}");
//     Console.WriteLine($"Dizinin Ortalamasi => {average}");
// }

// ArrayList numbers = new ArrayList();
// numbers.Add(5);
// numbers.Add(7);
// numbers.Add(9);
// numbers.Add(10);
// numbers.Add(3);

// SumArray(numbers);

// 5. verilen arraydeki en buyuk ve en kucuk sayiyi bulup ekrana yazan fonksiyon
// using System.Collections;

// static void MinMaxOfArray(ArrayList numbers)
// {
//     var maxNumber = int.MinValue;
//     var minNumber = int.MaxValue;
//     foreach (var number in numbers)
//     {
//         if ((int)number > maxNumber)
//         {
//             maxNumber = (int)number;
//         }
//         if ((int)number < minNumber)
//         {
//             minNumber = (int)number;
//         }
//     }
//     Console.WriteLine($"{maxNumber} is Biggest Number");
//     Console.WriteLine($"{minNumber} is Smallest Number");
// }

// ArrayList numbers = new ArrayList();
// numbers.Add(5);
// numbers.Add(7);
// numbers.Add(9);
// numbers.Add(10);
// numbers.Add(3);

// MinMaxOfArray(numbers);

// 6. verilen stringin ilk ve son harfi disindaki diger karakterleri gizleyerek ekrana yazan fonksiyon

// static void HideString(string input)
// {
//     var lenght = input.Length;
//     string result = input[0].ToString();
//     for (int i = 1; i < input.Length - 1; i++)
//     {
//         result += '*';
//     }
//     result += input[input.Length - 1];
//     Console.WriteLine(result);
// }

// HideString("Kasim");
#endregion

#region bir string ifadede hangi harfin kac defa tekrar ettigini bulan metod
/*
using System.Collections;

static void CountLetters(string input)
{
    input = input.ToLower();
    SortedList letters = new SortedList();
    for (int i = 0; i < input.Length; i++)
    {
        if (letters.ContainsKey(input[i]))
        {
            letters[input[i]] = (int)letters[input[i]] + 1;
        }
        else
        {
            letters.Add(input[i], 1);
        }
    }
    foreach (DictionaryEntry item in letters)
    {
        Console.WriteLine($"{item.Key} Harfi => {item.Value} defa tekrar ediyor.");
    }
}

CountLetters("Araba");
*/
#endregion

#region Sinif not durumuna gore ogrencileri ayiran metod
/*
using System.Collections;

static void SortStudents(SortedList list, int passingGrade)
{
    SortedList passed = new();
    SortedList failed = new();
    foreach (DictionaryEntry item in list)
    {
        if ((int)item.Key >= passingGrade)
        {
            passed.Add(item.Key, item.Value);
        }
        else
        {
            failed.Add(item.Key, item.Value);
        }
    }
    Console.WriteLine("Gecen Ogrenciler");
    foreach (DictionaryEntry item in passed)
    {
        Console.WriteLine($"{item.Value,10} ==> {item.Key,3}");
    }
    Console.WriteLine();
    Console.WriteLine("Kalan Ogrenciler");
    foreach (DictionaryEntry item in failed)
    {
        Console.WriteLine($"{item.Value,10} ==> {item.Key,3}");
    }
}

SortedList students = new();
students.Add(50, "Kasim");
students.Add(60, "Ali");
students.Add(40, "Hasan");
students.Add(55, "Orhan");
students.Add(20, "Mehmet");
students.Add(75, "Ahmet");
students.Add(30, "Caner");
students.Add(10, "Mert");

SortStudents(students, 50);
*/
#endregion

#region Diziye yeni ogrenci ekleyen, eklerken numara atamasi yapan, ogrenci adi dizide varsa isim degistirmeye yarayan bir fonksiyon
/*
using System.Collections;

static SortedList StudentList(SortedList list, string name)
{
    if (list.ContainsValue(name))
    {
        var number = list.GetKey(list.IndexOfValue(name));
        Console.WriteLine($"Degistirilecek Isim => {list[number]}");
        Console.WriteLine("Yeni Ismi Giriniz");
        list[number] = Console.ReadLine().Trim();
    }
    else
    {
        var rnd = new Random();

        list.Add(rnd.Next(100000, 1000000), name);
    }

    Console.WriteLine($"Ogrenci No || Isim & Soyisim");
    foreach (DictionaryEntry item in list)
    {
        Console.WriteLine($"{item.Key} || {item.Value}");
    }
    return list;
}

SortedList studens = new();
studens.Add(362200, "Kasim Pasaoglu");
studens.Add(444494, "Selcuk Yavuz");
studens.Add(496436, "Seda Pasaoglu");
studens.Add(555933, "CansuuPasaoglu");

StudentList(studens, "Kerem Pasaoglu");
StudentList(studens, "CansuuPasaoglu");
*/
#endregion

#region Dogum Tarihini alip kac yasinda oldugunu tam olarak dogru hesaplayan ve bir sonraki dogum gununun ne zaman oldugunu gosteren fonksiyon
/*
static void AgeCalculator(DateTime birthday)
{
    DateTime now = DateTime.Now;
    int yearDiff = now.Year - birthday.Year;
    if (now.Month < birthday.Month)
    {
        yearDiff--;
    }

    else if (now.Month == birthday.Month && now.Day < birthday.Day)
    {
        yearDiff--;
    }

    DateTime nextBirthday = birthday.AddYears(yearDiff + 1);

    Console.WriteLine($"{yearDiff} Yasindasiniz");
    Console.WriteLine($"Bir Sonraki Dogum Gununuz {nextBirthday.ToLongDateString()}");
}

Console.WriteLine("Dogum Tarihinizi Yaziniz (gg.aa.yyyy)");
DateTime input = DateTime.Parse(Console.ReadLine().Trim());
AgeCalculator(input);
*/
#endregion

#region Bir cumledeki en uzun kelimeyi bulan fonksiyon
/*
using System.Collections;

static string LongestWord(string text)
{
    string[] array = text.Split(' ');
    var longestWord = "";
    foreach (var item in array)
    {
        if (item.Length > longestWord.Length)
        {
            longestWord = item;
        }
    }
    return longestWord;
}

Console.WriteLine(LongestWord("Bu gun hava yagmurlu. Bu cumledeki en uzun kelime, gelemeyekmiscesine"));
*/
#endregion

#region SortedList Icine ArrayList Ekleme
/*
using System.Collections;

SortedList dersListesi = new();
dersListesi.Add("1.Sinif", new ArrayList() { "Turkce, Matematik, Tarih" });
dersListesi.Add("9.Sinif", new ArrayList() { "Fizik, Kimya, Edebiyat" });

static void DersListele(SortedList dersler, string sinif)
{
    // sorted list icinde key verip value alabiliyorduk
    ArrayList dersListe = (ArrayList)dersler[sinif];

    foreach (var item in dersListe)
    {
        Console.WriteLine(item);
    }
}

DersListele(dersListesi, "1.Sinif");
*/
#endregion

#region Bir metod icinden baska bir metod cagirmak
/*
using System.Collections;

// bu metod parametre olarak aldigi key degerindeki value'lar ile bir arraylist hazirlayip onu geri donduruyor
static ArrayList Hazirla(string ders)
{
    SortedList dersler = new();
    dersler.Add("1.Sinif", new ArrayList() { "Turkce", "Beden" });
    dersler.Add("2.Sinif", new ArrayList() { "Turkce", "Matematik" });
    dersler.Add("3.Sinif", new ArrayList() { "Fizik", "Biyoloji" });
    dersler.Add("4.Sinif", new ArrayList() { "Kimya", "Tarih" });
    ArrayList liste = (ArrayList)dersler[ders];
    return liste;
}

// bu metod yukardaki hazirla metodunu calistiriyor. Ordan aldigi ArrayListi ekrana yazdiriyor. 
static void DersleriGetir(string ders)
{
    ArrayList liste = Hazirla(ders);

    foreach (var item in liste)
    {
        Console.WriteLine(item);
    }
}
*/
#endregion

#region Bir string icinde kac tane rakam oldugunu bize soyleyen uygulama, 
/*
static bool IsNumber(char value)
{
    return char.IsDigit(value);
}

static void FindNumbers(string value)
{
    int totalDigits = 0;
    for (int i = 0; i < value.Length; i++)
    {
        if (IsNumber(value[i]))
        {
            totalDigits++;
        }
    }

    Console.WriteLine($"Girilen Metinde {totalDigits} adet rakam vardir");
}

FindNumbers("Bu or2n45kt3 yanlislikla 2rakam5 tuslanmis3t1r");
*/
#endregion

