#region ornek1
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

#region ekrandan bir metin alın, ilk harfi ve son harfini buyuk yapın dongu ile
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

#region bir metnin icindeki rakamları temizleyen kod ornegi yazınız
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

#region ekrandan aldıgımız bir string ifadenin icindeki buyuk harflerini, kucuk harflerını, karamlarını ayrı sayınız.
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

#region ekrandan aldıgımız sayıya kadar olan asal sayıları yazdırınız. Ekrana 11 yazılınca (2-3-5-7-11) cikmali.
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

#region dık ucgen cizdirip kose noktarına X isareti koyunuz
/*
for (int i = 0; i <= 6; i++)
{
    for (int j = 0; j <= i; j++)
    {
        if (i == 0)
        {
            Console.WriteLine("x");
            i++;
        }

        if (i == 6 && j == 0)
        {
            Console.Write("x");
        }

        Console.Write("*");

        if (i == 6 && j == 6)
        {
            Console.Write("x");
            j = 10;
        }
    }
    Console.WriteLine();
}
*/

// ikizkenar ucgen
for (int i = 1; i < 8; i++)
{
    for (int j = 0; j <= i; j++)
    {
        if (i <= 3)
        {
            Console.Write(" ");
            i++;

            if (j == 3)
            {
                Console.WriteLine("x");
                j += 20;
            }
        }
    }

    if (i > 1 && i < 7)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

#endregion