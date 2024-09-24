# Var Keyword

* Tum degisken tiplerinin yerine gecebilen bir keyword'tur. 
* Ancak object gibi boxing ve unboxing seklinde calismaz

```C#
    var a = 10;
    var b = "merhaba";
    var c = true;
```
> Bu sekilde butun degerler tanimlanabilir

```C#
    var sayi1 = 10;
    var sayi2 = 20;

    Console.WriteLine(sayi1 + sayi2);
    // sonuc 30 cikar
```
> Object'ten farkli olarak iki tane int'i toplayabildi.

* Calisma mantigi su sekilde; derleyici var'i gordukten sonra, esitlikten sonra verilecek deger neyse o tipi verir. 

* var keywordu tipsizdir

* Aslinda altyapida degisken tanimlamasini otomatik yapiyor, sadece kodu yazarken kolaylik saglamasi icin gelistirilmis. Yani CIL icinde tipini kendi tanimliyor.
```C#
var degisken = 10;
int degisken2 = 10;
```
>Bu tanimlamalar farkli gorunse de aslinda CIL tarafinda ikiside INT32 olarak tanimlandi.

* Butun tipler icin kullanilabilir
```C#
    var rnd = new Random();

    var datetime = new DateTime();
```

* `var` in cikis amaci, kodlamayi kolaylastirmak olmasinin yaninda ayni zamanda ileride gorecegimiz veri tabani ve entityframework asamasinda buyuk sorgulardan gelen tipleri kolay karsilamaktir.
* Ayrica ilerde gorecegimiz **anonim** tiplerdeki verileri karsilamak icin `var` kullanilabilir

```C#
    Console.WriteLine("bir sayi giriniz");
    var birinciSayi = int.Parse(Console.ReadLine());

    Console.WriteLine("bir sayi giriniz");
    var ikinciSayi = int.Parse(Console.ReadLine());
    Console.WriteLine(birinciSayi+ikinciSayi);
```
>Burda sadece `ReadLine()` fonksiyonu string dondugu icin `Parse` ile *int*'e donusturduk sonra direk var degiskenimize yazdik.  

* Ozetle; var tipi verdigimiz degere gore kendi tipini ayarlar.
* :warning: var keyworld'u yazilimcinin isini kolaytirir ancak okunmasini zorlastirabilir. 