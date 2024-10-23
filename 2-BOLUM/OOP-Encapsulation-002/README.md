- [Encapsulation (Kapsulleme)](#encapsulation-kapsulleme)
  - [Setter ve Getter Metodlari Iliskisi](#setter-ve-getter-metodlari-iliskisi)

# Encapsulation (Kapsulleme)

Encapsulation, nesneler ve bu nesnelerin icerisindeki degiskenlerle ilgili bir konudur.

- Temel olarak nesneler icindeki degiskenlerin, kontrolsuz bir sekilde dis dunyaya acilmasini engellemek amaciyla dusunulmustur.
- Bir nesne icindeki uyelerin dis dunya ile direk baglantili olmasi OOP'ye ters bir durumdur.
- Kapsulleme iki asamadan olusur.
    1. Nesneyi kapsullemek icin once erisim belirtecini `private` olarak ayarlariz.
    2. Nesneye erismek icin metod yazariz.

```C#
public class Personel
{
    private int id;
    private string name;
}
```

:bulb: Dis dunya ile haberlesmeyi bir metod uzerinden yapip ve bu metod icerisinde dis dunyadan gelene verileri kontrol etsek? Yani metod ile erismeli ve degistirebilmeli.

```C#
    public int Get_Id()
    {
        return id;
    }
    public string Get_Name()
    {
        return name;
    }
```

> Getter Metodlar: Gorevleri sadece nesne icindeki uyenin degerini nesne kullanicisina vermektir. Hicbir sekilde nesne degerini degistirmezler

```C#
    public void Set_Id(int id)
    {
        this.id = id;
    }

    public void Set_Name(string name)
    {
        this.name = name;
    }
```

> Setter Metodlar: Gorevleri sadece nesne icindeki uyenin degerini, nesne kullanicisi tarafindan gonderilen parametre ile degistirmektir. Geriye deger dodurmezler, sadece parametre alirlar ve aldiklari parametreyi nesne degiskenine atarlar.

:warning: Encapsulation ozellikle veri girisi yapilirken gerceklesebilecek hatalarin onune gecilmesi icin onemli bir kavramdir. Mesela personelin yasi icin veri girisi alirken, kullanici hatali olarak `person.age = 500` girisi yapabilir. ancak bir setter metod icinde kontrol saglarsak, (yas en fazla 80 olabilir gibi) artik boyle bir riski ortadan kaldirmis oluruz.

## Setter ve Getter Metodlari Iliskisi

- Ctor ile Encapsulation yanyana geldigi zaman genelde algi Ctor'larin nesnenin uyelerini koruduklaridir. Ancak Ctor verileri degiskenlere iletmekten baska birsey yapmaz
- Eger biz kapsulledigimiz degiskenlere ctor ile deger atarsak kapsullemenin bir anlami kalmaz.
- Bunu yapmanin dogru yolu, setter metodunu ctor icinden cagirmak gerekir.

```C#
    public Personel(int id, string name)
    {
        this.Set_Id(id);
        this.Set_Name(name);
    }
```

> [**INDEX'e DON**](/README.md)
