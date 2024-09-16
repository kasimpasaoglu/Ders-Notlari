#region for dongusu
/*
// belli bir kosul dogru oldugu surece tekrar tekrar calismasini istedigimiz kod bloklari icin

for (baslangic; kosul ; artis)
{
    tekrar edecek kod 
}

// baslangic : dongude kullanilacak degisken(sayac) baslatir
// kosul : bu kosul dogru oldugu surece dongu devam edecek
// artis : her tekrar sonrasi sayac nasil geistirilecek burda islenir
*/
#endregion

#region Ornek1: Sayactaki veriye disarda ihtiyacimiz yoksa direk icerde tanimlayabiliriz
/*
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("i'nin degeri: {0}", i);
}
// int i = 0 ile bir sayac baslattik
// i < 5 oldugu surece dongu devam edecek
// i++ ile her dongude sayaca 1 eklemis olacak. 
*/
#endregion

#region Ornek2 : Sayactaki veriye disarda ihtiyacimiz olacaksa tanimlamayi disarda yapabiliriz
/*
int i;
for (i = 0; i < 5; i++)
{
    Console.WriteLine("i'nin degeri: {0}", i);
}
*/
#endregion

#region ornek3: 0'dan 20'ye kadar olan cift sayilari yazdirmak
/*
for (int number = 0; number <= 20; number += 2)
{
    Console.Write("-{0}- ", number);
}
*/
#endregion

#region continue ile cift sayilari yazdirmak
// dongu icinde bir kosul girerek, bu kosul gerceklesirse o adimi atlamasini saglayabiliriz
/*
for (int number = 0; number <= 20; number++)
{
    if (number % 2 == 1) // bu kosul gerceklesirse
    {
        continue; // bu adimi atla
    }
    Console.Write("-{0}-", number);
}
*/
#endregion

#region Kullanicidan sayi al, o sayiya kadar olan tek sayilari yazdir
/*
// birinci yontem
Console.WriteLine("Ust Limiti Giriniz :");
int maxNumber = int.Parse(Console.ReadLine().Trim());

for (int i = 0; i <= maxNumber; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }
    Console.Write("-{0}-", i);
}

//ikinci yontem
Console.WriteLine("Ust Limiti Giriniz :");
int MaxNumber = int.Parse(Console.ReadLine().Trim());
for (int i = 1; i <= MaxNumber; i += 2)
{
    Console.Write("-{0}-", i);
}
*/
#endregion

#region Faktoriyel Hesaplama
/*
Console.WriteLine("Faktoriyel Alinacak Sayiyi Giriniz");
int number = int.Parse(Console.ReadLine().Trim());
int result = 1;
for (int i = 1; i <= number; i++)
{
    result *= i;
}
Console.WriteLine("sonuc => {0}", result);
*/
#endregion

#region verilen sayiya kadar olan asal sayilari bulma
/*
Console.WriteLine("Ust Sinir Giriniz");
int maxNumber = int.Parse(Console.ReadLine().Trim());

// 2'den baslayarak kullanicinin girdigi maxNumbera a kadar dongu olustuyoruz
// 2'den baslayarak o sayiya kadar olan sayilara tam bolunup bolunmedigini kontrol ediyoruz
for (int bolunen = 2; bolunen <= maxNumber; bolunen++) 
{
    bool isPrime = true; // baslangicta asal oldugunu varsayiyoruz. sonraki adimlarda asal degilse bu deger false olarak donecek.


    // ic dongude asal kontrolu yapiyoruz
    for (int bolen = 2; bolen < bolunen; bolen++) // bolen 2 den baslayip bolunen sayisina kadar olan her sayiya bakacak sekilde donguye girecek.
    {
        if (bolunen % bolen == 0) // eger bolunen, bolene tam bolunurse, asal degildir
        {
            isPrime = false; // sayinin asal olmadigini anladik (cunku baska bir sayiya tam bolundu). isPrime degiskeni artik false...
            break; // sayinin asal olmadigini anladik, ic donguyu durdur
        }

    }
    // ic donguden ciktiktan sonra isPrime Hala True ise:
    // o sayiyi konsola yazdir
    if (isPrime)
    {
        Console.Write("{0}-", bolunen); 
    }
    // dis dongu bolunen <= maxNumber kosulundan cikana kadar devam edecek. Burdan tekrar yukari gidip ayni islemleri bir daha yapacak. (icerdeki dongu de dahil)
    // daha iyi anlamak icin break point koyup adim adim takip et. 
}
*/
#endregion

#region verilen sayinin rakamlarini topla
/*
Console.WriteLine("Bir Sayi Girin :");
string input = Console.ReadLine().Trim();

int digits = input.Length; // sayi kac basamakli, (dongu bu basamak sayisi kadar olacak)
int inputNumber = int.Parse(input); // basamak sayisini bulduktan sonra int'e cevirdik
int total = 0; // toplam degerini burada tutacagiz, baslangicta 0

for (int i = 0; i < digits; i++) // sayac 0 dan baslayip basamak sayisina ulasana kadar dongu devam edecek
{
    int number = inputNumber % 10; // sayinin ilk basamagini al
    total += number;  // cikan sonucu total'e ekle
    inputNumber /= 10; // sayidan ilk basamagi cikar
}

Console.WriteLine(total); // sonucu yazdir
*/
#endregion

#region kullanicidan sayi al, o sayiya kadar olan sayilarin karesini yazdir
/*
Console.WriteLine("Bir Sayi Girin :");
int maxNumber = int.Parse(Console.ReadLine().Trim());

for (int i = 1; i <= maxNumber; i++)
{
    Console.WriteLine("{0} in karesi => {1}", i, i * i);
}
*/
#endregion

#region kullanicidan sayi al, o sayiya kadar olan sayilarin toplamini al
/*
Console.WriteLine("Bir Sayi Giriniz :");
int number = int.Parse(Console.ReadLine().Trim());
int total = 0;
for (int i = 1; i <= number; i++)
{
    total += i;
}
Console.WriteLine("1 den {0} e kadar olan sayilarin toplami => {1}", number, total);
*/
#endregion

#region carpim tablosu yazdirma
/*
Console.WriteLine("Carpim Tablosu Icin Bir Rakam Girin :");
int number = int.Parse(Console.ReadLine().Trim());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
}
*/
#endregion

#region tek bir sayinin asal kontrolu

using System.Diagnostics;
/*
Console.WriteLine("Kontrol Edilecek Sayiyi Girin :");
int number = int.Parse(Console.ReadLine().Trim());
Stopwatch stopwatch = Stopwatch.StartNew();  // performans olcumu yapiyorum
bool isPrime = true;
if (number == 1)
{
    Console.WriteLine("{0} bir asal sayi degildir.", number);
}
else
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.WriteLine("{0} bir asal sayidir.", number);
    }
    else
    {
        Console.WriteLine("{0} bir asal sayi degildir.", number);
    }
}
stopwatch.Stop(); // olcum bitti
Console.WriteLine("islem suresi => {0}ms", Math.Round(stopwatch.Elapsed.TotalMilliseconds, 2));
*/
#endregion