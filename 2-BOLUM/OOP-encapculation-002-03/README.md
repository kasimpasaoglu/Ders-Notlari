- [Yeni (Modern Encapsulation)](#yeni-modern-encapsulation)
  - [Ctor ile prop kullanimi](#ctor-ile-prop-kullanimi)
    - [Kavramlar](#kavramlar)

# Yeni (Modern Encapsulation)

Yeni yontemde kapsullemede sinifa ait degiskenler yoktur (field) direk olarak property'ler yaziliri
Eger bir sekilde field yazip kapsillemek istersek get ve set bloklarinin icerisinde bu islem yapilir

- read only erisimler icin read ve ya get bloklarindan herhangi birini yazmayabiliriz, ya da bu bloklarin onune private keywordu eklenebilir
- istenirse proplara baslangic degeri verilebilir.

:bulp: kisayol snippet `prop`

 ```C#
public class Personel
{
    public int Id { get; set; }
    public string Isim { get; set; }
    public int Yas { get; private set; }
    public double Maas { get; }
    public string IsYeri { get; set; } = "Karabuk Demir Celik";

}
```

- otomatik property'ler : bu prop cesitleri genelde hic bir private field'i kapsullemezler, kapsulleme ihtiyaciniz oldugunda bir onceki yontem ile kapsilleme islemi yapilmalidir.

## Ctor ile prop kullanimi

- Ortamlarda eger otomatik prop varsa ctor icerisinden gelen degerler direk otomatik proplara maplenirler
- Zaten otomatik prop kullaniliyorsa field yoktur.

```C#
    public Personel(int id, string isim, int yas, string isYeri)
    {
        Id = id;
        Isim = isim;
        Yas = yas;
        IsYeri = isYeri;
    }
```

### Kavramlar

Bir classin uyesi olan degiskene **field** denir
Bir metodun uyesi olan degiskene **local degisken** denir
Bir classin encapsulation uyesine **proterty** denir

:warning:

- Iki turlu degisken vardir,
    1. Birincisi metodlarin icersinde yasayan ve olen degilskenlerdir.
        - Bu degiskenlere local degisken denir.
    2. Diger tur degiskenler ise, sinif uyesi degiskenlerdir.
        - Bu degiskenler sinif yasadigi surece yasar, metodlardan bu degiskenlere erisilebilir,
        - Mantik olarak uye seviyesi olarak metotlarla ayni seviyedelerdir
        - Sinif uyesi degiskenlere field denir

> [**INDEX'e DON**](/README.md)
