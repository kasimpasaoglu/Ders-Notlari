# Inherit Siniflarda Ortak Metod Yazilmasi

* Yazilacak bir metodun kalitim hiyerarsisi icindeki her sinif icin kullanilabilir olmasi.
Ornek: BaseClass olarak Tasit classini, ondan kalitilan classlar icinde Mercedes, Bmw, Classlarini olusturalim

```C#
public class Tasit
{
    public int Enerji { get; set; }
}
```

```C#
public class Mercedes : Tasit
{
    public string Konfor { get; set; }
}
```

ve metodu yazalim

```C#
static void TasitMetod(Tasit tasit)
{

}
```

* Eger metodlara parametre alacagimiz nesneler arasinda bir kalitim hiyerarsisi var ise nesneleri tek tek parametre almaniza gerek yoktur. sadece Base Class'i parametre olarak aldigimiz taktirde, ondan tureyen tum siniflar bu metoda parametre olarak gecebilir.
  * Mercedes sinifini yukaridaki metoda parametre olarak gonderelim.

```C#
Mercedes m = new();
TasitMetod(m);
```

> Mercedes sinifi Tasit sinifindan turetildigi icin, parametre olarak Tasit verdigimiz metoda Mercedes nesnesini gonderebiliriz.

* Ancak burda sadece Base Classi kullanarak metod yazdigimiz icin sadece Base Class olan Tasit nesnesinin fieldlarina metodun icinden ulasabiliriz.
  * Yani `Mercedes` nesnesi icindeki `Konfor` field'ina `TasitMetod()` icinden ulasamiyoruz.
* Tureyen siniflar tasit parametresi alan metoda parametre olarak gonderilirse, aslinda boxing islemi yapilir.
* Dolayisiyla Mercedes nesnesi bu metoda parametre olarak gonderilirse tasit pointer'i uzerinden Mercedes nesnesine bakildigi icin sadece `Enerji` isimli prop gorunur.
* Mercedes nesnesine ait proplari gormek icin Tasit nesnesini Mercedes nesnesine cast (unboxing) yapmamiz gerekir.

```C#
static void TasitMetod(Tasit tasit)
{
    Mercedes merc = (Mercedes)tasit;
}
```

:warning: Ancak bu da baska bir sorunu ortaya cikariyor. Ya gelen parametre Mercedes degil de Bmw ise??

## `is` Keyword

* Kosul yapisi olusturup tasit mercedes ise mercedes unboxingi yapilabilir.

```C#
static void TasitMetod(Tasit tasit)
{
    if (tasit is Mercedes)
    {
        Mercedes merc = (Mercedes)tasit;
    }
    else if (tasit is Bmw)
    {
        Bmw merc = (Bmw)tasit;
    }
    else if (tasit is Peugeot)
    {
        Peugeot merc = (Peugeot)tasit;
    }
}
```

* `is` keywordu iki tipi birbiri ile kiyaslar.
  * Aslinda sordugu soru, "tasit degiskenin icinde bir Mercedes var mi?" seklindedir. bool doner.

## `override` Keyword

Kalitim yolu ile gelen metodlarin davranislarini degistirmek icin `override` keyword kullanilir.

```C#
public override strinf ToString()
{
    return "bu metod mercedes sinifinda degistirilmistir";
}
```
