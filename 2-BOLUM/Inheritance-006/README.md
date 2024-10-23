# Inheritance (Kalitim)

* Kalitim ust gruplardan alt gruplara miras yolu ile gecen bir yapidir.
* Bir ust soya ait bir ozelligin daha alt soylara gecmesidir.
* Yazilimsal olarak bir class'in tum ozelliklerini baska bir sinifa aktarmak icin kalitim yapisi kullanilabilir.

1. Tasit.cs dosyasinda Tasit diye bir class, KaraTasiti.cs dosyasinda KaraTasiti diye baska bir class olusturduk

```C#
//Tasit.cs
public class Tasit
{
    public int Kapasite { get; set; }
    public int Hiz { get; set; }
    public string Eneji { get; set; }
}

```

2. KaraTasiti sinifi tasit sinifindan kalitim almistir.(syntax => `tureyen sinif : turetilen sinif`)

```C#
//Karatasit.cs
public class KaraTasiti : Tasit
{

}
```

3. Simdi gelip bir karatasiti classi uzerinden nesne almak istedigimizde tasit sinifina ait proplari gorecegiz

```C#
//Program.cs
KaraTasiti arac = new();
arac.Kapasite = 4;
arac.Eneji = "Benzin";
arac.Hiz = 200;

Console.WriteLine(arac.Eneji);
Console.WriteLine(arac.Hiz);
Console.WriteLine(arac.Kapasite);
```

* :warning: Bir class sadece tek bir class miras alir. Birden fazla class'tan miras alinmaz
* :warning: Miras yoluyla olusturulmus bir class baska bir classa miras verebilir. Yani bir miras zinciri kurulabilir, ancak bir class ayni anda sadece bir classtan miras alabilir
* :bulb: inheritence kullanimi daha az kod yazilmasini saglar. Ornegin ad soyad yas bilgisi butun classlarda olacak ancak biz kisiye ozel classlar vermek istiyoruz, bazi classlarda yas, bazilarinda sac rengi gibi farkli ozellikler kullanilacaksa, once butun ortak ozellikleri iceren bir class olusturup diger classlari ordan inherit edebiliriz.

Bankalar Ornegi;
[BankBase.cs](/BankBase.cs) -> Butun Bankalar Burdan Inherit edildi

```C#
public class BankBase
{
    public string URL { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}
```

[Akbank.cs](/Akbank.cs)
[Garanti.cs](/Garanti.cs)
[SekerBank.cs](/SekerBank.cs)
[YapiKredi.cs](/YapiKredi.cs)
[Ziraat.cs](/Ziraat.cs) -> Ziraat Bankasinda fazladan bir prop eklendi

```C#
public class Ziraat : BankBase
{
    public string Renk { get; set; }
}
```

* Tum bankalara ayni proplara tanimlayarak geriye tum bankalarin `BankBase` classindan kalitilmasini sagladik.
* Bunu yaparak, aslinda ayni proplari birden fazla class icinde olmamasini sagladik.
* Ayrica propertylerin hepsinin ayni sekilde yazilmasini sagladik. *(biri Url digeri URL degil, hepsi URL oldu)*
* Ayrica herhangi bir classta bir prop unutulmasinin onune gectik.
* Herhangi bir classta ilave bir prop olmasini istiyorsak ilgili classa yazabiliriz. (Sadece ziraatin kullandigi bir prop varsa bunu en uste yazmaya gerek yoktur, direk ziraatin icine yazilabilir.)
* Yani geneli ilgilendiren bir prop en tepedeki classa verilebilir, ancak sadece bir classi ilgilendiren prop ilgili classa yazilmalidir.
* :arrow_down: Bu classlara ait nesne ornegi alalim

```C#
Akbank akbank = new();
akbank.URL = "www.akbank.com";
Garanti garanti = new();
garanti.URL = "www.garanti.com";



Ziraat ziraat = new();
ziraat.Renk = "Kirmizi";
// renk propu sadece Ziraat classina ait digerlerinde yok
```

## Inherit classlarda Bellek Hareketi

* Elimizde iki adet class olsun

```C#
public class A
{
    public string Aciklama { get; set; }
}
```

```C#
public class B : A
{

}
```

* B classi, A classindan turetilmis.

```C#
B be = new B();
be.Aciklama = "Tureyen sinif";
```

* A sinifinda bulunan Aciklama ozelligi B sinifina kalitildi.
* :bulb: Derleyici B sinifini bellege cikmak istediginde once kalitildigi sinif olan A sinifini bellege cikaracaktir, ozelliklerini alip ondan sonra B sinifini bellege cikarir.
