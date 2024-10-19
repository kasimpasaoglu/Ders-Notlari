# Metod OverLoading -> Metodlari Asiri Yuklemek

* Ayni isimde iki metod yazdigimizda bu iki metodun adi cakisacagi icin C# izin vermez.
* Ancak bazi durumlarda ayni isimde birden fazla metod yazilmasina izin verir.
* Birden fazla metodunun ayni ismi almasina **Metod Overloading** denir.
* Metod Overloading C# icinde cok fazla kullanilan bir yontemdir
* `Console.Writeline()` metodu alabilecegi parametrelere baktimizda 17 farkli overload'i oldugunu goruruz. Yani verdigimiz parametrelere gore farkli metodlari cagiriyoruz.
* Bir metodun overload olabilmesi icin, parametre sayisi, ve ya parametre tipi farkli olmalidir.
* Geri donus degerinin bir onemi yoktur. Ayni olsa da olur.
* C#' ta Program.cs dosyasina yazilan kodlar aslinda bir `Main()` metodu icine yazilir. Bu metod derleyiciye kodlari okumaya nerden baslayacagini gostermeye yariyor.
* Kendi yazdigimiz metolari overloading yapmak istiyorsak, bu `Main()` metodu disina yazilmalidir. `Main()` metodu icine overloading yapilamaz.
* Ilerleyen konularda kendi sinifinimizi olusturunca orda `Main()` metodu olmayacagi icin, overloading yapabilecegiz.

```C#
internal class Program
{
    private static void Main(string[] args)
    {
        // aslinda yazdigimiz butun kodlar buraya geliyor
    }
    static void Deneme(int a)
    {
    }
    static void Deneme(string a, string b)
    {
    }
}
```

## Metodlar - Params

Metodlar belli sayilarda parametre alirlar. Bu parametreleri bir keyword ile sinirsiz hale getirmek mumkundur

```C#
static void SinirsizParametre(params int[] parameters)
{
    // kod blogu
}

SinirsizParametre(10,20,30,40,50,60,70,80,90,100,1,2,3,4,5,6,7,8,9,0);
```

* `params` keyword'u bir metodun sinirsiz adet parametre almasini sagar.
* `params` ile alinan sinirsiz adet parametreler metod icinde dizi uzerinden yakalanabilir.

## Metodlar - Default Parameters

Bir fonskiyonda istege bagli parametre atamasi yapmak icin o parametreye default (baslangic) degeri atamasi yapilabilir.

```C#
static void Metod1(int a = 10)
{
    Console.WriteLine(a);
}

Metod1();

```

* Bu ornekte a degiskenin default degeri 10'dur.
* Metod cagirilirken a degiskenine deger atamasi yapilmazsa, default degeri alarak islem yapar,
* Deger atamasi yapilirsa verilen degeri kullanir.

> [**INDEX'e DON**](/README.md)
