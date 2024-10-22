# Sabitler

Yazilim icerisinde bazen sabit degerler vermek isteyebiliriz. Ornegin; Banka eft kodlari

```C#
if (secim=="Akbank")
{

}
// akbank
// AKBANK
// AkBaNk
```

> Her yazilimci "Akbank" i farkli sekilde yazabilir...

## Enum

Bu gibi durumlarda degisken atamasini yazilimciya birakmak yerine degiskenin her yerde ayni sekilde yazilabilmesi icin bir sabit deger atamasi yapilabilir. Bu sabit degiskenlere `enum` denir.

* Tanimlamak icin, yeni bir dosya acilip asagidaki syntax kullanilir;

```C#
public enum HaftaninGunleri{
    Pazartesi,
    Sali,
    Carsamba,
    Persembe,
    Cuma,
    Cumartesi,
    Pazar
}
```

* Kullanmak icin, `EnumAdi.deger` syntaxi kullanilir.

```C#
string pazartesi = HaftaninGunleri.Pazartesi.ToString();
Console.WriteLine(pazartesi);
```

C# icinde bazi hazir enumlar vardir `
Console.ForegroundColor = ConsoleColor.DarkBlue;` gibi.

* Enum sabitleri arka planinda bir deger tasirlar.
* Enum sabitlerine bir tip bildirilmedigi surece tasidiklari deger int olur,
* Eger farkli bir tip deger verilirse o tipte deger tasiyabilirler.
  * Degerlere tip atamasinini enum'u olustururken veririz.
  * :warning:Bu deger atamalarinda tipler tamsayi degisken tipleri olmak zorundadir. *string, double vs. verilemez.*
* Hic bir deger verilmezse otomatik olarak index numaralari alirlar.  

```C#
public enum Departmanlar : short
{
    Muhasebe = 10,
    Yazilim = 15,
    Satis = 20,
}
```

### Enum icindeki sabitler icinde dongu ile donmek

```C#
string[] enumSabitleri = typeof(Departmanlar).GetEnumNames();
foreach (string item in enumSabitleri)
{
    Console.WriteLine($"Departman Adi: {item}");
}

```

### Enum sabitlerinin rakamsal degerine ulasmak

* Enum'in sayisal degerine ulasmak icin tip donusumu yapilabilir;
`short muhasebe = (short)Departmanlar.Muhasebe;`
* Dongu icindeyken, her dongude o anki degeri Enum'a cevirmek icin `Enum.Parse()` metodunu cagiririz.
* Bu metod tipki diger Parse metodlari gibi calisir, ancak iki parametre alir, biri Enum'un tipi, digeri ise string deger.
  * Dolayisiyla `typeof(Departmalar)` ile tip bilgisini alip, dongu degiskenini de string olarak verirsek, Departmanlar tipindeki degere ulasmis olacagiz. Sonra bu degeri int ve ye; bu ornekte short oldugu icin o tipe donustursek sayisal degere ulasmis olacagiz.

### String Degeri Enum'a cevirmek

* Bunu yapmak icin Enum icindeki Parse metodunu kullanabiliriz.

`typeof()` Bir C# nesnesinin tip bilgisini doner.
:warning: `typeof()` kullanmamizin sebebi, calisma zamaninda bir turun meta verisini (type nesnesi) elde etmek ve bu tur bilgisine gore dinamik isler yapabilmektir. Ornegin; **Enum.Parse** metodu turun tam adini degil, tur bilgisini kullanarak stringleri enum turune donusturur.

```C#
string[] enumSabitleri = typeof(Departmanlar).GetEnumNames();
foreach (string item in enumSabitleri)
{
    Departmanlar seciliDepartman = (Departmanlar)Enum.Parse(typeof(Departmanlar), item);
    short departmanId = (short)seciliDepartman;
    Console.WriteLine($"Departman Adi: {item} || Kodu: {departmanId}");
}
```

> * Burda yaptigimiz islem; Enum.Parse ile dongunun o anki elemanini enum turune donusturduk. *Enum.Parse, object dondugu icin `(Departmanlar)` casting'i ile unboxing yaptik, adligimiz enum degerini `seciliDepartman` olarak tanimladik*
> * Aldigimiz enum'un sayisal degerine ulasmak icin tekrar tip donusumu yaptik `(short)`

---

## Constant(`const`)

* `const` keywordu ile bir class icinde olmak sarti ile, degistirilemez bir deger atamasi yapilabilir. Tanimlandigi class ici disinda hic bir yerde bu deger degistirilemez.

>*Const.cs* Dosyasi

```C#
public class Const
{
    public const string UserName = "WissenBesiktas";
}
```

* Bu deger cagrilabilir, okunabilir, ancak disardan degistirilemez.
* :warning: `const` keywordu sadece primitive tiplerle birlikte kullanilabilir.

```C#
var username = Const.UserName; // bu sekilde alabiliriz
Const.UserName = "Besiktas"; // bu sekilde deger atamasi yapilamaz. 
Math.PI // => pi sayisi da bir const'tur . Math classi icinde atamasi yapilmistir ve disardan degistirilemez.
```
