#region syntax
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