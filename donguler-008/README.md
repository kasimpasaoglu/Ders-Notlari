> [**INDEX'e DON**](/README.md)

# Donguler
Verilen sart saglanmadigi surece, belirli kod bloklarini, sart saglanana kadar tekrar calistiran yapilardir.
```
 Kosul
    {
    a satir
    b satir        ===> kosul gerceklesene kadar bu blok icindeki kodlari tekrar terkar calistir
    c satir
    }
```
 **DONGU CESITLERI**
 1. for dongusu (mantiksal operator)
 2. forEach dongusu (veri kaynagi) (dizilerden sonra ogrenecegiz)
 3. do while dongusu (mantiksal operator)
 4. while dongusu

 ## `for` Dongusu

 Syntax:
 ```C#
    for (int = i 0; i < 100; i++)  
    {

    }
    // bir degisken tanimlanmis (i), i 100'den kucuk oldugu surece (i < 100), asagidaki kod blogunu calistir, her tekrarda i'yi bir arttir (i++)
 ``` 
 `for ( degisken, kosul, her dongude degiskene yapilacak islem)`

 * Degisken her zaman dongunun icinde tanimlanmak zorunda degildir
 ```C#
    int i;

    for (i = 10; i < 100; i++)
    {

    }
 ```
 * Hic bir kosul vermeden bir dongu olusturulabilir. **(Sonsuz Dongu)**
 ```C#
    int a = 10;
    for (;;)
    {
        a++;
        Console.WriteLine(a);
    }
 ```
* Donen bir donguyu durdurma 
    * Kacis Keyworldleri ile (`break;`, `continue;`, `return;`)
    * Mevcut Kosulu Bozarak
```C#
    for (int i = 10; i < 100; i++)
    {
        // dongu 50 ye ulasinca sonlandiralim
        Console.WriteLine(i);
        if (i == 50) // i = 50 oldugunda
        {
            i = 101; // kosulu bozduk
        }
    }
```

* Ic ice `for` kullanimi
\
*Carpim Tablosu Ornegi*
```C#
    for (int i = 1; i <= 10; i++)  // bu dongu her dondugunde icerdeki dongu 10 kere donecek. 
    {
        for (int j = 1; j <= 10; j++)
        {
            Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
        }
        Console.WriteLine("-----------------------");
    }
```
## [Ara Konu (char metodlari)](README(char-metodlari).md)

## [Ara Konu (`break` ve `continue` kavramlari)](README(break-continue).md)

 ## `do / while` Dongusu
```C#
    do
    {
        //asagidaki kosul !saglanana! kadar tekrar tekrar calisacak kod blogu
    } while (kosul);
```

Ornek; kullanici 50 den buyuk bir sayi girene kadar calisacak bir kod yazalim
```C#
int girilenSayi = 0;
    do
    {
        Console.WriteLine("Bir Sayi Giriniz");
        girilenSayi = int.Parse(Console.ReadLine());
    } while (girilenSayi < 50);
```
> Girilen sayi 50 den kucuk oldugu surece donmeye devam eder.

> :warning: Gercek hayatta, cok kullanisli olmasina ragmen, bu donguyu pek goremezsiniz 

* While dongusu icinde `break` ve `continue` operatorleri kullanilabilir
* while dongusune kosul olarak `true` verilebilir, bu durumda dongu sonsuz dongu olur. 
    * Yani bir while dongusune kosul olarak `true` verip icerde `break` ile donguyu bitecek sekilde de yazilabilir.

## [Boxing Unboxing(Ara Konu)](README(boxing-unboxing).md)
## [Var Keyword(Ara Konu)](README(var-keyword).md)

## `while` Dongusu
* Diger tum donguler gibi bir kosul saglandigi surece icindeki kod bloklarini tekrarlar. 
* Kullanimi cok yaygin degildir.

*syntax*
```C#
    while(kosul)
    {
     kod blogu
    }
```
* `for` dongusunden farkli olarak dongu degiskeni ve arttirim/ azaltim ifadeleri barindirmaz, 
* sadece kosula baglidir, ve kosul saglandigi surece doner.
```C#
    while(true) // kosul true verildigi icin sonsuza kadar doner
    {
        Console.WriteLine("sonsuza kadar donecek")
    }
```

*ornek*
```C#
    int number = 0;
    while (number < 100)
    {
        number++;
        Console.WriteLine(number);
    }
```

> [**INDEX'e DON**](/README.md)