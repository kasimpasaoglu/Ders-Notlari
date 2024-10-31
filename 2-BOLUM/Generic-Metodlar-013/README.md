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
- Bu keyword olmadan derleyici gelen degerlerin + operatoru ile isleme alinip alinamayacagini bilmez.
- `dynamic` keywordu ile artik bu degisken

## Kisitlamalar `where` Keyword

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
