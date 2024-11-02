# Generic Metodlar

Derleme zamaninda parametre tiplerini degistirebildiginiz metodlardir.

- Metodu yazarken tip yerine `tip alias` veriliyor.
- metoda kac tane parametre alacagimizi belirtiyoruz

3 adet parametre alan geri deger donmeyen metod ornegi

```C#
static void GenericMetod1<T, K, L>(T value1, K value2, L value3)
{

}
```

bu metodu kullanalim

```C#
GenericMetod1<string, char, Personel>("String Parametre", 'c', new Personel());
```

> Kendi tipimizi de verebiliriz.

- T, K gibi ifadeler metod yazim esnasinda kullanir
- T,K gibi ifadeler metodun kullanim esnasinda developer tarafindan verilecek olan tiplerin yerine gecer
- Metod yazim asamasinda generic metod oldugu icin, tipi bu asamada belli degildir.
- Bu sebeple tip yazilmak yerine tip yerine gecebilecek kisaltmalar kullanilmaktadir.
- Bu kisaltmalar genelde T,K,L,M,N gibi kisaltmalar tavsiye edilir.
- Ancak buralara verilecek olan kisaltma isimlerinde bir sinirlama yoktur.
- Bazi kaynaklarda T,K,L,M,N kisaltmalarda sektor standartidir.
- Bazi kaynaklarda ise TKey, KValue gibi ifadelerde verilebilir.

## `dynamic` Keywordu

- Toplama yapan ve deger donen metod ornegi;

```C#
static L Toplama<T, K, L>(T value1, K value2)
{
    dynamic birinciSayi = value1;
    dynamic ikinciSayi = value2;
    return birinciSayi + ikinciSayi;
}
```

`Console.WriteLine(Toplama<int, int, double>(10, 2));`
 int parametre alip double donsun dedik.

`Console.WriteLine(Toplama<string, string, string>("Merhaba ", "Dunya"));`
 iki string verirsek bu metod yine calisacaktir

- `dynamic` tipki var gibi ancak daha gucli bir keyword'tur.
- Aslinda generic ile alakasi yok.
- Bu keyword olmadan derleyici gelen degerlerin + operatoru ile isleme alinip alinamayacagini bilmez.
- `dynamic` keywordu ile artik bu degisken

## Kisitlamalar  & `where` Keyword

- Bu tarz kisitlanmamis metodlarda icerde yapabilecegimiz islem cok kisitlaniyor.
- Ancak metoda gelebilecek parametrelerde bir kisitlama yaparsak daha rahat hareket edebiliriz

### Interface kisitlamasi

Asagidaki ornekte T tipi IComparable interface implementasyonu olan tipleri alacak demis istiyoruz.

```C#
static T EnBuyuk<T>(T a, T b) where T : IComparable
{
    if (a.CompareTo(b) == -1)
    {
        return b;
    }
    else if (a.CompareTo(b) == 1)
    {
        return a;
    }
    else
    {
        return a;
    }
    // a buyukse 1, b buyukse -1, ikisi esitse 0 donuyor.
}
```

Kontrol Edelim

```C#
Console.WriteLine(EnBuyuk<int>(20, 10));
// string te IComparable interface implementasyonu icerdigi icin string ile de calistirabiliriz
Console.WriteLine(EnBuyuk<string>("Ahmet", "Zeynep"));
```

#### Kendi Class'imiza `IComparable' Eklemek

Implementasyonu yaptiktan sonra, C# bizden CompareTo metodunu yazmamizi isteyecek.

```C#
public class Ogrenci : IComparable
{
    public int OgrenciId { get; set; }
    public int CompareTo(object? obj)
    {
        Ogrenci parametreOgrenci = (Ogrenci)obj;
        if(this.OgrenciId>parametreOgrenci.OgrenciId)
        {
             return 1;
        }
        else if(this.OgrenciId<parametreOgrenci.OgrenciId){
            return -1;
        }
        else 
        {
            return 0;
        }
    }
}
```

Bu tanimlamanin ardindan artik daha once hazirladigimiz `EnBuyuk()` metodunu artik Ogrenci sinifi icin de kullanabilir hale getirdik.

```C#
var enBuyuk = EnBuyuk<Ogrenci>(new Ogrenci(){   OgrenciId=19},new Ogrenci(){ OgrenciId=5});

Console.WriteLine("En Büyük : "+enBuyuk.OgrenciId);
```

## Generic Kisitlar : Default ctor Kisiti

Generic metodumuza default Ctor kisiti koyalaim. Yani Default ctoru olmayan classlar ile birlikte calismasin

```C#
static void CtorKisit<T>(T value1) where T : new()
{

}
```

Personel classinda ise default ctor yok

```C#
public class Personel
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public Personel(int id, string name)
    {
        Id = id;
        Ad = name;
    }
}
```

Bu yuzden personel sinifi ile bu metodu kullanmaya calistigimizda hata verecektir.

```C#
CtorKisit<Personel>(new Personel(10, "Ahmet"));
```

## Generic Kisitlar : Kalitilma Kisiti

- Kalitim kisitinda 2 kosul vardir;
  - Ya o siniftan kalitilmis olmak, ya da direk o sinifi kullanmak

BaseClass isimli classtan kalitilmis olma sarti ve ya BaseClass sinifinin parametre olarak gelme sarti eklendi

```C#
static void Kalitim<T>(T value1) where T:BaseClass
{

}
```

int bir BaseClass degildir hata verir -> `Kalitim<int>(10);`

- Daha once yazdigimiz Personel classina base class kalitimi ekledikten sonra;
`Kalitim<Personel>(new Personel(20,"Nalan"));`
- Artik personel classi, BaseClass' tan kalitim aldigi icin bu metoda parametre olarak gonderilebilir.

## Generic Kisitlar : Referans Tip(class) ve ya Deger Tip(struct) Olma Kisiti

```C#
static void SinifKisit<T>(T value)where T: class
{

}
```

- `SinifKisit<bool>(true);` -> deger tip(struct) oldugu icin  **hata verir**
- `SinifKisit<string>("Kemal");` -> string bir referans tip oldugu icin metoda parametre olarak **gonderilebilir**
- `SinifKisit<Personel>(new Personel(10, "Ahmet"));` -> personel sinifi bir referans tip oldugu icin **gonderilebilir**.
- `SinifKisit<Wissen>(new Wissen());` -> wissen bir struck olarak yazildigi icin **hata verir**

### Coklu kisitlama ornegi

- T Tipi hem referenas tip olmali, hem IDisposable'dan kalitilmis olmali, K tipi deger tipli olmalidir.

```C#
static void CokluKisit<T, K>(T value, K value1)where T: class, IDisposable where K: struct
{

}
```
