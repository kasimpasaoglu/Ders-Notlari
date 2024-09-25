#region rasgele sayi olusturup array icine yaz
/*
Console.WriteLine("Kac Adet Random Sayi Olusturulsun?");
var requestedCount = int.Parse(Console.ReadLine());

Console.WriteLine("Olusturulacak Sayilar En Az Kac Olmali?");
var minValue = int.Parse(Console.ReadLine().Trim());

Console.WriteLine("Olusturulacak Sayilar En Fazla Kac Olmali?");
var maxValue = int.Parse(Console.ReadLine().Trim());

int[] randomNumbers = new int[requestedCount];

var rnd = new Random();

for (int i = 0; i < requestedCount; i++)
{
    randomNumbers[i] = rnd.Next(minValue, maxValue + 1);
}

do
{
    Console.WriteLine("Kacinci sayiyi gormek istediginizi girin");

    Console.WriteLine("Cikmak icin 'exit' yaziniz");

    var input = Console.ReadLine().Trim().ToLower().ToString();

    if (input == "exit")
    {
        break;
    }

    var indexRequested = int.Parse(input) - 1;

    if (indexRequested >= 0 && indexRequested < requestedCount)
    {
        Console.WriteLine("{0}. Sayi => {1}", input, randomNumbers[indexRequested]);
    }
    else
    {
        Console.WriteLine("1 ile {0} araliginda gecerli bir deger girin", requestedCount);
    }

} while (true);
*/
#endregion

#region ortalama hesapla, ortalamanin altindaki ve ustundeki degerleri goster
/*
Console.WriteLine("Kac adet not girilecek?");
var numbersCount = int.Parse(Console.ReadLine().Trim());
var numbers = new int[numbersCount];
double total = 0;

for (int i = 0; i < numbersCount; i++)
{
    Console.WriteLine("{0}. Sayiyi Giriniz :", i + 1);
    var inputNumber = int.Parse(Console.ReadLine().Trim());
    numbers[i] = inputNumber;
    total += inputNumber;
}

double average = Math.Round(total / numbersCount, 2);

Console.WriteLine("Girdiginiz {0} adet sayinin ortalamasi => {1}", numbersCount, average);
Console.WriteLine("--------------------------------------------------------------");

var aboveAverage = 0;
var belowAverage = 0;
var equalAverage = 0;

Console.WriteLine("Ortalamanin Ustunde Olan Sayilar;");
for (int i = 0; i < numbersCount; i++)
{
    if (numbers[i] > average)
    {
        Console.Write("-" + numbers[i] + "-");
        aboveAverage++;
    }

}
Console.WriteLine();
Console.WriteLine("{0} Adet Sayi Ortalamanin Ustunde", aboveAverage);
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine("Ortalamanin Altinda Olan Sayilar;");
for (int i = 0; i < numbersCount; i++)
{
    if (numbers[i] < average)
    {
        Console.Write("-" + numbers[i] + "-");
        belowAverage++;
    }
}
Console.WriteLine();
Console.WriteLine("{0} Adet Sayi Ortalamanin Altinda", belowAverage);
Console.WriteLine("--------------------------------------------------------------");

Console.WriteLine("Ortalamaya Esit Olan Sayilar;");
for (int i = 0; i < numbersCount; i++)
{
    if (numbers[i] == average)
    {
        Console.Write("-" + numbers[i] + "-");
        equalAverage++;
    }
}
Console.WriteLine();
Console.WriteLine("{0} Adet Sayi Ortalamaya Esit", equalAverage);
Console.WriteLine("--------------------------------------------------------------");

*/
#endregion

#region Rasgele Sayilardan Kullanicinin istegi kadar dizi olustur, Bu dizideki en buyuk ve en kucuk sayiyi bul, ortalamasini al, ve kullanicinin girdigi degerden buyuk/kucuk/esit kac tane sayi oldugunu bul.
/*
Console.WriteLine("Kac Adet Sayi Olusturulsun");
var numberCount = int.Parse(Console.ReadLine().Trim());

Console.WriteLine("0 - 100 arasi bir deger girin");
var numberInput = int.Parse(Console.ReadLine().Trim());

var rnd = new Random();

var numbers = new int[numberCount];

var biggestNumber = 0;
var smallestNumber = 100;

double total = 0;
double average = 0;
var smallerNumbersCount = 0;
var biggerNumbersCount = 0;
var equalNumbersCount = 0;

for (int i = 0; i < numberCount; i++)
{
    numbers[i] = rnd.Next(0, 101);
    Console.Write("-" + numbers[i] + "-");
    total += numbers[i];
    if (numbers[i] > biggestNumber)
    {
        biggestNumber = numbers[i];
    }
    if (numbers[i] < smallestNumber)
    {
        smallestNumber = numbers[i];
    }

    if (numbers[i] < numberInput)
    {
        smallerNumbersCount++;
    }
    if (numbers[i] > numberInput)
    {
        biggerNumbersCount++;
    }
    if (numbers[i] == numberInput)
    {
        equalNumbersCount++;
    }
}
average = Math.Round(total / numberCount, 2);
Console.WriteLine();
Console.WriteLine("Serideki En Buyuk Sayi => {0}", biggestNumber);
Console.WriteLine("Serideki En Kucuk Sayi => {0}", smallestNumber);
Console.WriteLine("Serinin Ortalamasi => {0}", average);
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("Dizide girdiginiz sayidan({0}) buyuk {1} adet, kucuk {2} adet ve esit {3} sayi var", numberInput, biggerNumbersCount, smallerNumbersCount, equalNumbersCount);
*/
#endregion

