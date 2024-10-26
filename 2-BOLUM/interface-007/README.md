# Interface

* Interface, yapisal itibariyle kalitim gibi gorunse de, aslinda miras alip verme durumu ya da siniflarin kendi iclerinde hiyerarsisi yoktur.
* Interface yazilacak olan siniflara yon gostermek ve yazilacak olan siniflarin sablonu olmak icin vardir.
* Interface yazilirken kesinlikle 'I' on eki ile yazilmalidir. *Ornek: IAraba, IOgrenci.*

```C#
public interface IAraba
{
    void Calis();
    void Dur();
    void BakimYap();
}
```

* interface icerisinde metod yazilacak ise sadece imzasi yazilir. Metod govdesi bu interface'i kullanan(sablon olarak alan) siniflar icin yazilir, her govde birbirinden farkli olabilir.
* interface icerisinde metodun geri donus tipi ve aldigi parametreler vardir.
* erisim belirtec yazilmaz, cunku erisim belirtec bu interfacein uygulanacagi sinif icerisinde belirlenir.

```C#
public class Mercedes : IAraba
{
    // asagidaki metodlar interface implementasyonu sonrasinda sinifa geldiler
    // interface'den gelen metodlarin imzasinda degisiklik yapilamaz.
    public void BakimYap()
    {
        throw new NotImplementedException();
    }

    public void Calis()
    {
        throw new NotImplementedException();
    }

    public void Dur()
    {
        throw new NotImplementedException();
    }
}
```

* inherit yapar gibi : IAraba eklendigikten sonra hata verdi, cunku interface ile zorunlu kilinan metodlar henuz yazilmamisti.
  * metodlari elle yazmak yerine vs code otomatik getirme secenegi sunuyor.
* Burdaki metodlar interface implementasyonu sonrasinda sinifa geldiler
* interface'den gelen metodlarin imzasinda degisiklik yapilamaz.
* Bir interface pointeri kendisini implemet etmis tum siniflari isaret edebilir.
`IAraba araba = new Mercedes()`

**Baska Bir Ornek:**

```C#
public interface IDenizTasit
{
    void Git();
    void Dur();
}
```

```C#
public interface IHavaTasit
{
    void Uc();
    void In();
}
```

* hovercraft hem denizde hem de havada gidebilen bir arac oldugu icin, birden fazla interface implement edebilir.

```C#
public class HoverCraft : IHavaTasit, IDenizTasit
{
    public void Dur()
    {
        throw new NotImplementedException();
    }

    public void Git()
    {
        throw new NotImplementedException();
    }

    public void In()
    {
        throw new NotImplementedException();
    }

    public void Uc()
    {
        throw new NotImplementedException();
    }
}
```

* interface ler kendi baslanarina new'lenemezler
`IHavaTasit havatasit = new IHavaTasit();`

* Ancak interface tipinde bir dizi yapilabilir
`IHavaTasit[] havaTasit = new IHavaTasit[10];`

* Dizinin her bir index'ine bir pointer atamasi yapmis olduk
* Bu pointerlari, bu interface'i kullanan classlara newleyerek nesle uretilebilir.
`havaTasit[0] = new HoverCraft();`
