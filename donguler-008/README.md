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
 2. forEach dongusu (veri kaynagi)
 3. do while dongusu (mantiksal operator)

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
