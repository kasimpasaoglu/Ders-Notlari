- [Sabitler](#sabitler)
  - [Enumeration (`Enum`)](#enum)
    - [Enum icindeki sabitler icinde dongu ile donmek](#enum-icindeki-sabitler-icinde-dongu-ile-donmek)
    - [Enum sabitlerinin rakamsal degerine ulasmak](#enum-sabitlerinin-rakamsal-degerine-ulasmak)
    - [String Degeri Enum'a cevirmek](#string-degeri-enuma-cevirmek)
  - [Constant (`const`)](#constantconst)
  - [Readonly (`readonly`)](#readonlyreadonly)
  - [Class/Nesne Kavramlari Hatirlatma](#hatirlatma)

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

- Tanimlamak icin, yeni bir dosya acilip asagidaki syntax kullanilir;

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

- Kullanmak icin, `EnumAdi.deger` syntaxi kullanilir.

```C#
string pazartesi = HaftaninGunleri.Pazartesi.ToString();
Console.WriteLine(pazartesi);
```

C# icinde bazi hazir enumlar vardir `
Console.ForegroundColor = ConsoleColor.DarkBlue;` gibi.

- Enum sabitleri arka planinda bir deger tasirlar.
- Enum sabitlerine bir tip bildirilmedigi surece tasidiklari deger int olur,
- Eger farkli bir tip deger verilirse o tipte deger tasiyabilirler.
  - Degerlere tip atamasinini enum'u olustururken veririz.
  - :warning:Bu deger atamalarinda tipler tamsayi degisken tipleri olmak zorundadir. *string, double vs. verilemez.*
- Hic bir deger verilmezse otomatik olarak index numaralari alirlar.  

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

- Enum'in sayisal degerine ulasmak icin tip donusumu yapilabilir;
`short muhasebe = (short)Departmanlar.Muhasebe;`
- Dongu icindeyken, her dongude o anki degeri Enum'a cevirmek icin `Enum.Parse()` metodunu cagiririz.
- Bu metod tipki diger Parse metodlari gibi calisir, ancak iki parametre alir, biri Enum'un tipi, digeri ise string deger.
  - Dolayisiyla `typeof(Departmalar)` ile tip bilgisini alip, dongu degiskenini de string olarak verirsek, Departmanlar tipindeki degere ulasmis olacagiz. Sonra bu degeri int ve ye; bu ornekte short oldugu icin o tipe donustursek sayisal degere ulasmis olacagiz.

### String Degeri Enum'a cevirmek

- Bunu yapmak icin Enum icindeki Parse metodunu kullanabiliriz.

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

> - Burda yaptigimiz islem; Enum.Parse ile dongunun o anki elemanini enum turune donusturduk. *Enum.Parse, object dondugu icin `(Departmanlar)` casting'i ile unboxing yaptik, adligimiz enum degerini `seciliDepartman` olarak tanimladik*
> - Aldigimiz enum'un sayisal degerine ulasmak icin tekrar tip donusumu yaptik `(short)`

---

## Constant(`const`)

- `const` keywordu ile bir class icinde olmak sarti ile, degistirilemez bir deger atamasi yapilabilir. Tanimlandigi class ici disinda hic bir yerde bu deger degistirilemez.

>*Const.cs* Dosyasi

```C#
public class Const
{
    public const string UserName = "WissenBesiktas";
}
```

- Bu deger cagrilabilir, okunabilir, ancak disardan degistirilemez.
- :warning: `const` keywordu sadece primitive tiplerle birlikte kullanilabilir.

```C#
var username = Const.UserName; // bu sekilde alabiliriz
Const.UserName = "Besiktas"; // bu sekilde deger atamasi yapilamaz. 
Math.PI // => pi sayisi da bir const'tur . Math classi icinde atamasi yapilmistir ve disardan degistirilemez.
```

- Bir `const` degisken tanimlanirken baslangic degeri verilmelidir. Yani constant tanimlari derleme asamasinda, kod yazilirken verilmelidir. Verilmezse derleme zamani hatasi alinir.
  - Bu yuzden sonradan bir constant degisken yazilamaz. (ornegin kullanicidan alinan deger gibi)

## Readonly(`readonly`)

- Tanimlamasi icin asagidaki syntax ile yazilir.
`public readonly string firmaAdi;`
- Readonly bir sabit degiskendir ve ustune yazma islemi gerceklesmez.
- Sadece okuma islemi yapabilecegimizden dolayi bir sabittir.
- const ile aralarindaki fark ise, readonly degiskene baslangicta deger vermek zorunda degiliz,
- nesne uzerinden deger atamasi yapilamaz, ancak `ctor` araciligi ile deger atamasi yapilabilir.

```C#
Sabit c = new Sabit();
c.firmaAdi = "sdfsd";
```

> bu sekilde atama yapilamaz

```C#
public class Sabit
{
    public readonly string FirmaAdi;

    public Sabit(string firmaAdi)
    {
        this.FirmaAdi = firmaAdi;
    }
}
```

> Class icinde bu sekilde ctor ile yazilmalidir.

```C#
Sabit c = new Sabit("FirmaX");
```

> Olusturulan ctor ile birlikte deger atamasi yapilabilir.

- :bulb:`const` bir sinifin elemanidir, `readonly` bir nesnenin elemanidir. **Not: static konusunda detayli konusulacak.**

### Hatirlatma

- **Class** : Bir Sablondur. Insan bir siniftir. Icinde bir cok ozellik barindirir. (iki bacagi iki kolu var gibi)

- **Nesne** : Classtan aldigi sablona gore olusturulmus elemanlardir. Ahmet, Ayse gibi ogeler insan classi ile olusturulmus nesnelerdir. Ozelliklerini insan classindan alarak meydana gelmis ogelere nesne denir.

```C#
Insan ahmet = new Insan()
// insan classindan uretilen ahmet nesnesi...
// Ahmet nesnesinin, yas cinsiyet, boy, kilo gibi ozellikleri olabilir.
// Nesnelerin tasidiklari degerler farkli olabilir. Yas, kilo boy gibi ozellikler birbirinden farkli olabilir. 
```

- Simdi son yazdigimiz maddeyi biraz acalim.

  ```C#
  //Sabit.cs
  public class Sabit
  {
    public const string Username = "wissenBesiktas"

    public readonly string FirmaAdi;
    
    public Sabit(string firmaAdi)
    {
      this.FirmaAdi = firmaAdi;
    }
  }
  ```

  - biri `const` digeri `readonly` olan iki adet degiskenimiz var
  - `const` bir degiskene class adi yazip sonra ulasabiliriz.
  - `readonly` degiskene ise nesne uzerinden ulasiriz.

  ```C#
  //Program.cs
  Sabit.Username;                 // Sabit classi uzerinden ulastik
  
  Sabit s = new Sabit("Wissen");  // nesne olusturduk
  s.FirmaAdi;                     // nesne uzerinden ulastik
  ```

  **- :warning: `const` olan degiskene direk class adi uzerinden erisebilirken, `readonly` olan degiskene nesne uzerinden erisebiliyoruz**
