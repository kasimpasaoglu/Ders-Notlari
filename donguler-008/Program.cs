﻿#region ornek1
/*
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}
*/
#endregion

#region ornek 1- 1000 arasi 5 er yazdiralim
/*
for (int i = 0; i < 1000; i+= 5)
{
    Console.WriteLine(i);
}
*/
#endregion

#region ters siralama
/*
for (int i = 1000; i >= 0; i--)
{
    Console.WriteLine(i);
}
*/
#endregion

#region sonsuz dongu
/*
int a = 10;
for (; ; )
{
    a++;
    Console.WriteLine(a);
}
*/
#endregion

#region Donguyu durdurma, kosulu bozarak 
/*
for (int i = 10; i < 100; i++)
{
    // dongu 50 ye ulasinca sonlandiralim
    Console.WriteLine(i);
    if (i == 50) // i = 50 oldugunda
    {
        i = 101; // kosulu bozduk
    }
}
*/
#endregion

#region Caprim Tablosu Yazdirma
/*
for (int i = 1; i <= 10; i++)  // bu dongu her dondugunde icerdeki dongu 10 kere donecek. 
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
    }
    Console.WriteLine("-----------------------");
}
*/
#endregion

#region ornek => 1000 adet random sayi cekip bu sayilardan kac tanesi tek kac tanesi cift
/*
Random rnd = new Random();
int oddCount = 0, evenCount = 0;

for (int i = 0; i < 1000; i++)
{
    int number = rnd.Next();

    if (number % 2 == 0)
    {
        evenCount++;
    }
    else
    {
        oddCount++;
    }
}
Console.WriteLine("{0} adet tek sayi", oddCount);
Console.WriteLine("{0} adet cift sayi", evenCount);
*/
#endregion

#region Ekrana 10 karakterli random bir kelime yazdirin
/*
string text = "";
Random rnd = new Random();

for (int i = 0; i < 10; i++)
{
    char letter = Convert.ToChar(rnd.Next('a', 'z'));
    text += letter;
}
Console.WriteLine("Random Text => {0}", text);
*/
#endregion

#region Ornek 1=> Ekrandan x adet sayi alin. bu sayilarin girilen en kucugunu ve en buyugunu ekrana yazdiralim. 
/*
int biggestNumber = 0;
int smallestNumber = 2000000000;
for (int i = 1; i < 5; i++)
{

    Console.WriteLine("Bir Sayi Giriniz");
    int number = int.Parse(Console.ReadLine().Trim());
    if (number > biggestNumber)
    {
        biggestNumber = number;
    }
    if (number < smallestNumber)
    {
        smallestNumber = number;
    }
}
Console.WriteLine("En Buyuk Sayi => {0}", biggestNumber);
Console.WriteLine("En Kucuk Sayi => {0}", smallestNumber);
*/
#endregion

#region Ornek 2=>ic ice for dongusu ile ekrana asagidaki sekli cizdir
/*
x
xx
xxx
xxxx
xxxxx
*/
/*
for (int i = 1; i < 6; i++)
{
    for (int j = 1; j < i; j++)
    {
        Console.Write("x");
    }
    Console.WriteLine("x");
}
*/
#endregion

#region Ornek 2=> Random 1 ile 100 arasindan bir sayi tutalim. For Dongusu ile ekrandan sayi girisi alalim, Kullanicinin girdigi degere random tutulan degerden kucek ise yukari, buyuk ise asagi yazdirarak, kullanciyi yoneldirip sayiyi bulmasini sagla, Kullanicinin 10 tahmin hakki olsun, 10 hakta bilemezse, ekrana kaybettiniz yazalim.
// DERSTEN SONRA DUZELT: Kaybettiniz Kismini dongu sonlandiktan sonra yap
/*
Random rnd = new Random();
int answer = rnd.Next(1, 100);



for (int i = 0; i < 10; i++)
{
    Console.WriteLine("{0}. Tahmininizi Giriniz", i + 1);
    int userInput = int.Parse(Console.ReadLine().Trim());

    if (userInput > answer)
    {
        Console.WriteLine("Daha Kucuk Bir Sayi Girin");
    }
    if (userInput < answer)
    {
        Console.WriteLine("Daha Buyuk Bir Sayi Girin");
    }
    if (userInput == answer)
    {
        Console.WriteLine("Tebrikler Kazandiniz. Sayi => {0}", answer);
        i = 10;
    }
}
if (i = 9 || i = 10);
{
        Console.WriteLine("Kaybettiniz Sayi => {0} olacakti.", answer);
}
*/
#endregion

#region Ogrenciden 10 adet not alip bu notlarin ortalamasini bulan program yaziniz,
/*
double userInput = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("{0}. Notunuzu Giriniz", i + 1);
    userInput += double.Parse(Console.ReadLine().Trim());
}
Console.WriteLine("Not Ortalamaniz => {0}", Math.Round(userInput / 10, 2));
*/
#endregion

#region Ekrandan, almis oldugunuz bir yaziyi dongu kullanarak, ekrana ters yazdiriniz.
/*
Console.WriteLine("Bir Metin Giriniz...");

string userInput = Console.ReadLine().Trim();
int inputIndexLenght = userInput.Length - 1;

for (int i = 0; i <= inputIndexLenght; i++)
{
    Console.Write(userInput.Substring(inputIndexLenght - i, 1));
}
*/
#endregion

#region ekrandan bir metin alin, ilk harfi ve son harfini buyuk yapin dongu ile
/*
Console.WriteLine("Bir Metin Giriniz");
string userInput = Console.ReadLine().Trim();

string result = "";
int inputLenght = userInput.Length;

for (int i = 0; i < inputLenght; i++)
{
    string letter = userInput.Substring(i, 1);
    if (i == 0 || i == inputLenght - 1)
    {
        letter = letter.ToUpper();
    }
    result += letter;
}

Console.WriteLine(result);
*/
#endregion

#region bir metnin icindeki rakamlari temizleyen kod ornegi yazin
/*
Console.WriteLine("Icınde Rakam Olan Metın Giriniz");
string input = Console.ReadLine().Trim();
string output = "";

for (int i = 0; i < input.Length; i++)
{
    char letter = char.Parse(input.Substring(i, 1));

    if ((letter >= 65 && letter <= 90) || (letter >= 97 && letter <= 122) || (letter == 32))
    {
        output += letter;
    }

}
Console.WriteLine(output);
*/
#endregion

#region ekrandan aldigimiz bir string ifadenin icindeki buyuk harflerini, kucuk kucuk harflerini, rakamlarini ayri ayri sayiniz.
/*
Console.WriteLine("Bir Metin Giriniz :");
string input = Console.ReadLine().Trim();

int lowerCaseCount = 0;
int upperCaseCount = 0;
int digitCount = 0;
int whiteSpaceCount = 0;

for (int i = 0; i < input.Length; i++)
{
    char chars = char.Parse(input.Substring(i, 1));

    if (char.IsUpper(chars))
    {
        upperCaseCount++;
    }

    if (char.IsLower(chars))
    {
        lowerCaseCount++;
    }
    if (char.IsDigit(chars))
    {
        digitCount++;
    }
    if (char.IsWhiteSpace(chars))
    {
        whiteSpaceCount++;
    }
}
Console.WriteLine("{0} adet buyuk, {1} adet kucuk karakter, {2} adet rakam ve {3} adet bosluk girdiniz", upperCaseCount, lowerCaseCount, digitCount, whiteSpaceCount);

*/
#endregion

#region ekrandan aldigimiz sayiya kadar olan asal sayilari yazdiriniz. Ekrana 11 yazilinca (2-3-5-7-11) cikmali.
/*
Console.WriteLine("Ust siniri giriniz:");
int limit = int.Parse(Console.ReadLine().Trim());

for (int i = 2; i <= limit; i++)
{
    bool isPrime = true;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
        }
    }

    if (isPrime)
    {
        Console.WriteLine(i);
    }
}
*/
#endregion

#region diger yontem
/*
Console.WriteLine("Bir Limit Girin");
int limit = int.Parse(Console.ReadLine());

for (int i = 2; i <= limit; i++)
{
    int sayac = 0;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            sayac++;
        }
    }
    if (sayac == 0)
    {
        Console.WriteLine(i);
    }
}
*/
#endregion

#region dik ucgen cizdirip kose noktarina X isareti ve kenarlarini | \ isareti yapiniz
/*
Console.WriteLine("Bir Deger Giriniz");
int number = int.Parse(Console.ReadLine().Trim());

for (int i = 0; i < number; i++)
{

    for (int j = 0; j <= i; j++)
    {
        if (i == 0 && j == 0)
        {
            Console.Write('o');
        }
        else if ((i == number - 1 && j == 0) || (i == number - 1 && j == i))
        {
            Console.Write('o');
        }
        else if (j == 0)
        {
            Console.Write('|');
        }
        else if (j == i)
        {
            Console.Write('\\');
        }
        else if (i == number - 1 && j > 0 && j < i)
        {
            Console.Write('-');
        }
        else
        {
            Console.Write('*');
        }
    }
    Console.WriteLine();
}
*/

#endregion

#region ikizkenar ucgen cizdiriniz
/*
for (int i = 0; i < 10; i++)
{

    for (int j = i; j < 10; j++)
    {
        Console.Write(" "); // bosluklar
    }

    for (int x = 0; x <= i; x++)
    {
        Console.Write("*");
        Console.Write(" ");
    }
    Console.WriteLine(); // satirlar
}
*/

#endregion

#region Kenarlari / ve \ isaretleri ile yapalim
/*
Console.WriteLine("Bir Deger Girin");
int input = int.Parse(Console.ReadLine().Trim());


for (int i = 0; i < input; i++)
{

    for (int j = 0; j < input - 1 - i; j++)
    {
        Console.Write(" ");

    }
    Console.Write("/");

    if (i == input - 1)
    {
        for (int k = 0; k <= i * 2; k++)
        {
            Console.Write("-");
        }
    }

    else
    {
        for (int k = 0; k <= i * 2; k++)
        {
            Console.Write("*");
        }
    }

    Console.Write('\\');

    Console.WriteLine();
}
*/
#endregion

#region sayi tahmin oyununu break kullanarak tekrar yapiniz
/*
Random rnd = new Random();
int number = rnd.Next(0, 100);

bool isUserWon = false;

Console.WriteLine("Sayi tahmininizi Giriniz (10 hakkiniz var)");
for (int i = 0; i < 10; i++)
{
    int guessesLeft = 10 - (i + 1);
    int input = int.Parse(Console.ReadLine().Trim());

    if (guessesLeft == 0)
    {
        break;
    }

    if (input > number)
    {
        Console.WriteLine("Asagi ({0} Hakkiniz Kaldi)", guessesLeft);
    }

    if (input < number)
    {
        Console.WriteLine("Yukari ({0} Hakkiniz Kaldi)", guessesLeft);
    }

    if (input == number)
    {
        isUserWon = true;
        break;
    }
}

if (isUserWon)
{
    Console.WriteLine("Tebrikler Kazandiniz");
}
else
{
    Console.WriteLine("Tahmin Hakkiniz Kalmadi Sayi => {0}", number);
}
*/
#endregion

#region do/while Ornek1 50 den kucuk girme
/*
int girilenSayi = 0;
do
{
    Console.WriteLine("Bir Sayi Giriniz");
    girilenSayi = int.Parse(Console.ReadLine());
} while (girilenSayi < 50);
*/
#endregion

#region kullanicidan kullanici adi ve sifre alarak bir giris kontrolu yapiniz (do/while ile)
/*
string userNameData = "wissen";
string passwordData = "besiktas123";

Console.WriteLine("Kullanici Adinizi Giriniz:");
string userNameInput = Console.ReadLine().Trim();
do
{
    Console.WriteLine("Hatali Giris Tekrar Deneyiniz");
    userNameInput = Console.ReadLine().Trim();
} while (userNameInput != userNameData);

Console.WriteLine("Sifrenizi Giriniz:");
string userPasswordInput = Console.ReadLine().Trim();

do
{
    Console.WriteLine("Hatali Giris Tekrar Deneyiniz");
    userPasswordInput = Console.ReadLine().Trim();
} while (userPasswordInput != passwordData);

Console.WriteLine("Giris Basarili");
*/
#endregion

#region BOLUM SONU ODEVI (FIBONACCI Sayi Dizisi Yazdirma)
// a-b-c-d....n => c=a+b / d=b+c //
/*
Console.WriteLine("Kac adet sayi yazdirilsin?");
var count = int.Parse(Console.ReadLine());
if (count < 0 || count >= 46)
{
    do
    {
        Console.WriteLine("Lutfen 0 ile 45 arasi bir deger giriniz.");
        count = int.Parse(Console.ReadLine());
    } while (count < 0 || count >= 46);
}

var numberCurrent = 0;
var numberBeforeFirst = 1;
var numberBeforeSecond = 0;
for (int i = 0; i < count; i++)
{
    numberCurrent = numberBeforeFirst + numberBeforeSecond;
    Console.WriteLine(numberCurrent);
    numberBeforeSecond = numberBeforeFirst;
    numberBeforeFirst = numberCurrent;
}
*/
#endregion

#region tekrar oynanabilir sayi tahmin oyunu
/*
var replay = 'e';
do
{
    var rnd = new Random();
    var answer = rnd.Next(0, 100);

    Console.WriteLine("Tahmininizi Girin (10 Hakkiniz Kaldi)");
    var input = int.Parse(Console.ReadLine().Trim());

    for (int i = 0; i < 10; i++)
    {
        if (i == 9)
        {
            Console.WriteLine("Kaybettiniz. Sayi => {0}", answer);
            break;
        }
        else if (input == answer)
        {
            Console.WriteLine("Tebrikler Sayiyi Buldunuz");
            break;
        }
        if (input > answer)
        {
            Console.WriteLine("ASAGI. Kalan Hakkiniz {0}", 9 - i);
            input = int.Parse(Console.ReadLine().Trim());
        }
        else if (input < answer)
        {
            Console.WriteLine("YUKARI. Kalan Hakkiniz {0}", 9 - i);
            input = int.Parse(Console.ReadLine().Trim());
        }
    }

    Console.WriteLine("Tekrar Oynamak Ister Misiniz? (e/h)");
    replay = char.Parse(Console.ReadLine().Trim());

} while (replay == 'e');
*/
#endregion

#region girilen sayinin basamaklarini toplama
/*
var replay = 'e';

do
{
    Console.WriteLine("Bir sayi giriniz:");
    var inputString = Math.Abs(int.Parse(Console.ReadLine().Trim())).ToString();
    var inputStringLength = inputString.Length;
    var total = 0;

    for (var i = 0; i < inputStringLength; i++)
    {
        var digit = int.Parse(inputString.Substring(i, 1));
        total += digit;
    }

    if (total % 9 == 0)
    {
        Console.WriteLine("{0} Sayisinin rakamlari toplami 9'un katidir", inputString);
    }

    Console.WriteLine("{0} sayisinin rakamlari toplami => {1}", inputString, total);
    Console.WriteLine("Tekrar denemek ister misiniz (e/h)");

    replay = char.Parse(Console.ReadLine().Trim());

} while (replay == 'e');
*/
#endregion

#region while ornek 1'den 100'e kadar degerleri yazdir
/*
int number = 0;
while (number < 100)
{
    number++;
    Console.WriteLine(number);
}
*/
#endregion

#region while ile carpim tablosu
/*
int i = 1;
while (i <= 10)
{
    int j = 1;
    while (j <= 10)
    {
        Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
        j++;
    }
    i++;
    Console.WriteLine("---------------------------");
}
*/
#endregion

#region dik ucgeni while ile cizelim
/*
int i = 0;
while (i < 10)
{
    int j = 0;
    while (j < i)
    {
        Console.Write('*');
        j++;
    }
    Console.WriteLine();
    i++;
}
*/
#endregion

#region eskenar uscgeni while ile cizelim
/*
int i = 0;
while (i < 10)
{
    int j = i;
    while (j < 10)
    {
        // bosluklar
        Console.Write(' ');
        j++;
    }

    int k = 0;
    while (k <= i * 2)
    {
        // sutunlar
        Console.Write('*');
        k++;
    }
    // satirlar
    Console.WriteLine();
    i++;
}
*/
#endregion

#region while ile ekrandan 10 adet not alip ortalamasi yazin
/*
double total = 0;
int count = 1;
while (count <= 10)
{
    Console.WriteLine("{0}. Notu Giriniz", count);
    total += double.Parse(Console.ReadLine().Trim());
    count++;
}
Console.WriteLine("Not Ortalamaniz {0}", Math.Round(total / count, 2));
*/
#endregion

#region 1 den 10.000 e kadar tek sayi ve cift sayilarin toplami
/*
int totalEvens = 0;
int totalOdds = 0;
int i = 1;
while (i <= 10000)
{
    if (i % 2 == 0)
    {
        totalEvens += i;
    }
    else
    {
        totalOdds += i;
    }
    i++;
}

Console.WriteLine("Tek Sayilar Toplami => {0}", totalOdds);
Console.WriteLine("Cift Sayilar Toplami => {0}", totalEvens);
*/
#endregion

#region while ile sayi tahmin oyunu
/*
var replay = 'e';
while (replay == 'e')
{

    var rnd = new Random();
    var answer = rnd.Next(0, 100);

    var guessRight = 10;

    var guessCount = 1;

    while (guessCount <= guessRight)
    {
        Console.WriteLine("{0}. Tahmininizi Girin", guessCount);
        var input = int.Parse(Console.ReadLine().Trim());

        if (input == answer)
        {
            Console.WriteLine("Kazandiniz... Cevap => {0}", answer);
            break;
        }

        else if (guessCount == guessRight)
        {
            Console.WriteLine("Kaybettiniz...");
            Console.WriteLine("Ekstra 5 Tahmin Hakki Ister Misiniz? (e/h)");
            var joker = char.Parse(Console.ReadLine().Trim());

            if (joker == 'e')
            {
                guessRight += 5;
            }

            else
            {
                Console.WriteLine("Cevap => {0} olacakti.", answer);
                break;
            }

        }

        else if (input > answer)
        {
            Console.WriteLine("Asagi");
        }

        else if (input < answer)
        {
            Console.WriteLine("Yukari");
        }

        guessCount++;
    }

    Console.WriteLine("Tekrar Oynamak Ister Misiniz? (e/h)");
    replay = char.Parse(Console.ReadLine().Trim());
}
*/
#endregion

