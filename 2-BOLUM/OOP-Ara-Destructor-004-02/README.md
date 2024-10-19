# Destructor

Nesne bellekten duserken yapilmasini istedigimiz isler icin yazilir. Ctor ile ayni yapida yazilir basina, `~` isareti konulur

```C#
public class Personel
{

    public int Id { get; set; }
    public string Ad { get; set; }

    public Personel()
    {

    }
    ~Personel()
    {

    }
}
```

* C#'ta bellek yonetimi: Garbage collector hic bir pointer tarafindan isaret edilmeyen nesneleri toplar.
* Bir pointera `null` degeri atanirsa, pointer ortadan kalkacagi icin C# o veriyi cope atar.
* Garbage Collector manuel olarak devreye sokulsa da manuel calistirmak onerilmez. `GC.Collect();`
* Desctructor GC'nin bellegi silme asamasinda calisan bir yapidir. Nesne bellekten duserken son olarak yapilacak isler **(ornegin, veritabani baglantilarini sonlandirmak, dosya baglantilarini kapatman vb.)**

> [**INDEX'e DON**](/README.md)
