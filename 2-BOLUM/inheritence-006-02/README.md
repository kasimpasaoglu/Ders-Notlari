# `base`  Keywords

`this` ve `:this` keyword'lerine benzer kullanimlardir.
Aradaki fark;

* `this` ile kendisine kalitilan propertiy'e erisirsin.(Yani class icindeki prop'lara erisir)
* `base` ile kalitilan prop'un aslina erisirsin. (Base Classtaki propa dogrudan erismek icindir.)

> **Driven (tureyen)** class icinde bir ctor olusturuldugu zaman, **Base Class (turetilen)** icindeki fieldlara erismek icin `base` anahtar kelimesini kullanabiliriz.

```C#
// Tasit.cs
public class Tasit
{
    public int Kapasite { get; set; }
    public Tasit(int kapasite)
    {
        Kapasite = kapasite;
    }
}
```

```C#
// HavaTasit.cs
public class HavaTasit : Tasit
{
    public HavaTasit(int kapasite) : base(kapasite)
    {
        base.Kapasite = 10;
    }
}
```

> * `:base` ile ise base class'in ctoruna yonlendirme islemi yapilabilir.
> * Artik base class'tan kalitim yolu ile gelen Kapasite isimli field'a dogrudan erisim yapilabilir. `base.Kapasite = 10;`

:bulb: `:base` keyword'u ile base sinifin ctoru'una bir yonlendirme islemi yaptik. tipki `this` ile ayni classtaki ctorlar arasinda yonlendirme yaptigimiz gibi.

## Kullanim Amaci

* Cunku alt sinif nesne uretirken, her zaman once ust siniftaki ctoru bellege gonderir. sonra geri gelip, alt sinifi olustururken verdigimiz degerleri bellege gonderir.
* Bu da 2 defa bellege gidip gelmeye sebep olur.
* Burdaki amac, alt siniftan bir nesne olusturuyor olsak bile verecegimiz degerleri bereaberinde alip bellege bir kere gidip yazmasini saglamaktir.
* Yani base anahtar kelimesi ile, base classin ctoruna yonlendirme islemi yapmis olmak.
