# Kosullar (Karar Mekanizmalari)

- Bir yazilimin en onemli bilesenidir
- Derleyiciye belli degerlere gore belli kod bloklarini calistirmasini soyleme yontemidir. 
- Calisma Mantigi: 
- Elimizde bir *kosul* var.
-- Kosul true ise bu kod calissin
-- Degilse bu kod calissin
C# 'ta iki farkli kosul yontemi var
1. `if - else if - else` yontemi 
2. `Switch Case` yontemi

## `if`
```C#
    if(kosul)
    {
        kosul true ise bu kod blogu(scope) calisacak
    }
```
* not, kosul her zaman mantiksal operatorden gelen bir deger almalidir (true/false). Yani if parantezi ya direk true false bir deger kabul eder, ya da sonucu true/false donecek bir mantiksal operator islemi alir.

```C#
Console.WriteLine("Lutfen Bir Sayi Giriniz");
int intDegisken = int.Parse(Console.ReadLine());
// cift mi?
    if (intDegisken % 2 == 0)
    {
        Console.WriteLine("Girdiginiz sayi cift");
    }
    // cift degil mi?
    if (intDegisken % 2 != 0)
    {
        Console.WriteLine("Girdiginiz sayi tek");
    }
```

## `if-else`
* yukaridaki ornek her ne kadar dogru sonucu veriyor olsa da derleyici iki adet sorgu yapmis oluyor. Oysaki zaten girdigimiz kosul cift degilse zaten tektir. Yani ikinci if sorgusuna gerek yok. Bu tarz sadece iki durumu kontrol ediyorsak `else` kullaniyoruz. Boylece iki sorgu yapmiyoruz. \
Yani if kosulunu bir kere kontrol ediyoruz, dogru ise if blogu calisacak, degilse else blogu calisacak. \
Eger if blogu calisirsa `else` blogunu asla kontrol etmez

```C#
    Console.WriteLine("Lutfen Bir Sayi Giriniz");
    int intDegisken = int.Parse(Console.ReadLine());

    // cift mi kosulu dogru ise bu blok calisir
    if (intDegisken % 2 == 0)
    {
        Console.WriteLine("Girdiginiz sayi cift");
    }

    // degilse ...
    else
    {
        Console.WriteLine("Girdiginiz sayi tek");
    }
```

*derste verilen odev1
```C#
    Console.WriteLine("bir karakter girin");
    int input = Convert.ToInt32(char.Parse(Console.ReadLine()));

    if (input > 64 && input < 91)
    {
        Console.WriteLine("Girdiginiz Harf Buyuk");
    }
    else
    {
        Console.WriteLine("Girdiginiz harf kucuk");
    }
```
Bu ornekteki sorun su: Kullanicinin girecegi karakterin ASCII kodu 64, 91 araligi disinda hangi deger gelirse gelsin Ekrana `Girdiginiz Harf Kucuk` yazisi cikacak. Bu da aslinda tam olarak istedigimiz sey degil. Buna deginecegiz
* if ve else kosullarinda, eger bu bloklarin icinde tek satir kod girilecekse  paranteze alamamiza gerek yoktur
```C#
    Console.WriteLine("bir karakter girin");
    int input = Convert.ToInt32(char.Parse(Console.ReadLine()));

    if (input > 64 && input < 91)
        Console.WriteLine("Girdiginiz Harf Buyuk");
    
    else
        Console.WriteLine("Girdiginiz harf kucuk");
    
```
* if bloklari icine baska if bloklari ve else bloklari da yazabiliriz.

```C#
if (kosul)
{
    if(baskaBirKosul)
    {

    }
    else
    {

    }
}
else
{
    if (kosul)
    {

    }
    else
    {
        
    }
}
```