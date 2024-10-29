# Table Of Contents

- [`static` Keyword](#static-keyword)
  - [static ctor](#static-ctor)
  - [non-static bir sinif icinde static uye](#non-static-bir-sinif-icinde-static-uye)

# `static` Keyword

Yazilan classlar iki sekilde kullanilabilir

1. Daha once ogrendigimiz o siniftan bir nesne uretmek ve nesne uzerinden sinifi kullanmak
2. Hic nesne uretmeye gerek kalmadan o sifini kullanmak.
Static kavrami ikinci yol olarak karsimiza cikmaktadir.

- Static kavrami icerisinde sinifia ait nesne uretilmez
  - ornek `Math.Cos()`
- Static classtan nesne uretilemez
  - `Math m = new Math(); // uretilemez.`
- Daha once kullandigimiz static classlar;
  - `int.Parse();` , `Console` , `ToString();`
- Static class neden kullanilir?
  - Cok hizli bir sekilde erisilmek istenen metod, prop, ya da const lar icin static classlar daha kullanislidir.

```C#
public static class Personel
{
    public static ArrayList Liste { get; set; }
}
```

- Static classlarin icindeki butun uyelerin static olmasi gereklidir.
- Bunu sebebi, non-static bir ogeye erismek icin nesne ornegi alinmasi gerekmektedir. Ancak static siniflarda nesne ornegi alinamadigi icin, static siniflarda non-static bir oge yazilamaz.
- Static class icindeki ogeye , su sekilde erisilir;
`var liste = Personel.Liste;`

## static ctor

- `this` keyword'u static siniflar icin kullanilmaz
- Static ctorlar sadece bir kez calisir
- sSatic ctorlar parametre alamazlar, ve overloading yapilmaz.

```C#
public static class Personel2
{
    public static int Maas { get; set; }
    static Personel2()
    {
        Maas = 100;
    }
}
```

> static ctor icersiinde maas degiskeni bellege ciksin diye deger verildi.

## non-static bir sinif icinde static uye

- Non static bi class icine static bir uye yazilabilir.
- Bir class icinde hem static hem non-static class yazilabilir.

> Static bir uye ile non-static uye arasindaki farki gormek icin, bu siniftan uretilen nesne sayilarini saklayan bir degisken yazalim, ve ctor her calistiginda bu degiskenleri 1 arttirsin

```C#
public class Ogrenci
{
    public Ogrenci()
    {
        StaticNesneSayisi++;
        NonStaticNesneSayisi++;
    }
    static Ogrenci()
    {

    }

    public static int StaticNesneSayisi { get; set; }
    public int NonStaticNesneSayisi { get; set; }

    public void DersCalis()
    {
        Console.WriteLine("Ders Calisildi");
    }
    public static void OkulaGit()
    {
        Console.WriteLine("Okula Gidildi.");
    }
}
```

> static olan uye dogrudan class icinde oldugu icin ctor her calistiginda degerini arttirarak devam ederken non-static olan uye sadece nesneyle beraber calistigi icin ilgili nesne uretildiginde onunla beraber bir kez (uretilirken) calisacak

```C#
Ogrenci o1 = new Ogrenci();
Ogrenci o2 = new Ogrenci();

Console.WriteLine(Ogrenci.StaticNesneSayisi); // 2 kez ogrenci nesnesi olusturuldugu icin bu satir 2 yazacak
Console.WriteLine(o2.NonStaticNesneSayisi); // o2 nesnesi sadece bir kez uretildigi icin bu satir 1 yazacak
```

- :bulb: non-static uyeye erisim nesne uzerinden yapilirken static uyeye erisim dogrudan class uzerinden yapilir

```C#
Ogrenci o = new Ogrenci();
o.DersCalis(); // non-static DersCalis metoduna nesne uzerinden erisilir

Ogrenci.OkulaGit(); // static OkulaGit metoduna class uzerinden erisilir
```

:warning:

- static sinifin uyesidir
- non-static nesnenin uyesidir.
- static tum nesneleri kapsar, cunku nesnelerden ustundur ve bagimzi hareket eder.
