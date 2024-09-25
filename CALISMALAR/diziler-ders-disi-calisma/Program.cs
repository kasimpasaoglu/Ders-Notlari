#region Ornek1 - random olusturulan dizideki tek ve cift sayilari bul

Console.WriteLine("Kac Adet Sayi Olusturulsun?");
var numbers = new int[int.Parse(Console.ReadLine().Trim())];

var rnd = new Random();
// kac adet tek/cift sayi olusturuldugunu takip edebilmek icin iki adet degisken hazirladik
var evenCount = 0;
var oddCount = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(100, 1000);

    if (numbers[i] % 2 == 0)
    {
        evenCount++; // sayi ciftse evenCount'u 1 arttir
    }
    else
    {
        oddCount++; // degilse oddCount'u 1 arttir
    }
}

// kac adet tek/cift sayi geldigini biliyoruz. ekrana yazdiralim...
Console.WriteLine($"{evenCount} adet cift, {oddCount} adet tek sayi olusturuldu...");

// bu veri ile artik tek ve cift sayilari kaydetmek icin array hazirlayabiliriz. 
// array uzunluklarinin kac olmasi gerektigi bilgisine sahibiz.
var evenNumbers = new int[evenCount];
var oddNumbers = new int[oddCount];

// asagidaki index degiskenlerine, sayilari array'e atamak icin ihtiyacimiz olacak, 
// 0 dan baslayarak arraye her bir sayi eklendiginde bir sonraki sayi dogru siraya gelmesi icin 1 arttircaz. 
// dongunun icindeki i degiskenini kullanamayiz cunku tek ve cift sayilar iki ayri arrayde olacagi icin, ayri ayri indexlenmesi gerekir.
var evenNumbersIndex = 0;
var oddNumbersIndex = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenNumbers[evenNumbersIndex] = numbers[i];
        // aciklama: mesela i=4 e kadar tek sayi gelirse, bu index degeri olmasaydi, evenNumbers[i] yazsaydik, ilk 0-1-2-3 elemanlarini bos gecmis olurduk. Sonucta hem sayilar arraye sigmazdi hemde ekrana yazdirirken sorun yasardik.  
        evenNumbersIndex++;
        // eger sayi ciftse o anki index'e yazdiktan sonra, indexi 1 arttirip blogu tamamliyoruz. boylece bir sonraki sayida kaldigimiz yerden atamaya devam edecegiz
    }
    else
    {   // ayni mantikla tek sayilar icin de ayni islemi yapiyoruz.
        oddNumbers[oddNumbersIndex] = numbers[i];
        oddNumbersIndex++;
    }
}

// sonuclari ekrana yazdiralim
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Cift Sayilar:");
for (int i = 0; i < evenNumbers.Length; i++)
{
    Console.Write("-{0}-", evenNumbers[i]);
}
Console.WriteLine();


Console.WriteLine("--------------------------------------------");
Console.WriteLine("Tek Sayilar:");
for (int i = 0; i < oddNumbers.Length; i++)
{
    Console.Write("-{0}-", oddNumbers[i]);
}

#endregion