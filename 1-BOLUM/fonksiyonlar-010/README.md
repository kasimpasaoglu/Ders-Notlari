# Table Of Contents

- [Metodlar (Fonksiyonlar)](#metodlar-fonksiyonlar)
  - [METOD TURLERI](#metod-turleri)
  - [KURALLAR](#kurallar)
  - [ARA BILGI (SortedList Icine Bir ArrayList Ekleme)](#ara-bilgi-sortedlist-icine-bir-arraylist-ekleme)
  - [Bir metod icinde baska bir metodu cagirmak](#bir-metod-icinde-baska-bir-metodu-cagirmak)

# Metodlar (Fonksiyonlar)

Bir is yapan kucuk program parcalaridir. C# jargonunda metod olarak isimlendirilir fakat genel yazilim dunyasinda fonksiyon olarak isimlendirilir.

- Metodlar parametre alabilir ve ya almadan islem yapabilir
- Metodlar islem tamamlandiktan sonra disariya bir deger donebilir ve ya donmeyebilir.
- Metod yazildiginda bellekte yer kaplamaz ve derleyici tarafindan derlenmez. Ancak cagrildigi zaman o zaman bellekte belli bir miktar alan isgal eder, ve isi bitince tekrar silinir. Her cagrildiginda bu dongu tekrar eder. Bu yuzden metod yazildigi yerden daha ust bir satirda cagrilabilir.

> Gercek hayatta bir problemle karsilastigimizda bunlari cozmek icin bir yol arariz. Buyuk bir problemle ugrasmak daha zordur. Bu tarz durumlarda buyuk problemi kucuk parcalar haline bolup oyle cozmeye calismak onerilir.\
Yazilim dunyasinda bu tarz buyuk isleri cozmek icin ufak parcalara ayirmak metodlarla yapilir.

## METOD TURLERI

1. Parametre Alan Metodlar
    - `Next()` , `Replace()` gibi bu gune kadar kullandigimiz metodlardan parametre alarak calisan metodlara ornektir
2. Deger Donduren Metodlar
    - `ToLower()`, `Next()` gibi metodlar calistiktan sonra disariya deger dondurur.
3. Parametre Almayan Metodlar
    - `Clear()` gibi metodlar calismak icin parametre ihtiyaci duymayan metodlara ornektir.
4. Geriye Deger Dondurmeyen Metodlar
    - `Sort()` , `Reverse()` gibi metodlar calistiktan sonra disariya bir deger dondurmeyen metodlardir.

>Syntax:\
erisim belirteci + static / static degil + geri donus tipi / deger donmeyecekse void + metod adi (metod parametreleri){ fonksiyonun kendi kodlari}

- Erisim Belirteci: bir metodun hangi katmandan ya da nereden erisebilecegini belirler
  - **public** : Her katmanda erisilebilir
  - **private** : Sadece kendi katmanindan erisilebilir
  - **protected** : Kalitim hiyerarsisi olan katmanlardan erisilebilir, diger katmanlara kapalidir.
  - **protected** internal : Ya kalitim hiyerarsisi ya da dis bir paket tarafindan erisilebilir.
  - **internal** : sadece dis bir paket tarafindan erisilebilir

:bulb: bir sure sadece public kullancaz

- **Static ya da Static olmama**: Metodlar icin en onemli kavramlardan biridir.
:bulb: bir sure sadece static kullanacagiz.
- **Geri donus tipi**: bir metodtan geriye, dotnet icindeki tum degisken tipleri donebilir. Ancak metod geriye deger dondurmuyorsa `void` olarak isaretlenmelidir.
- **Metod adi**: metodun yapacagi is ile ilgili isimlendirme yapilmalidir. Tek karakter ve ya anlamsiz isimler kodun okunabilirligini bozacagi icin, duzgun bir isimlendirme yapilmalidir. **Pascal** casing (WissenMetod) kullanilmalidir.
- **Metodun Parametreleri**: Bir metod, 1 veya birden cok parametre alabilir. Kac adet parametre alacaginin bir siniri yoktur. Ayni geri donus tipinde oldugu gibi, dotnet icindeki tum degisken tiplerini parametre olarak alabilir.

## KURALLAR

- Metod yazarken, metod icerisindeki kod satir sayisinin yaklasik 30'u asmamasina dikkat etmek gerekmektedir. Bu bir hataya sebep olmasa da genel kabul edilen, yazili olmayan kural 30 satirdir. Fazlasi hos karsilanmaz.
- Metod parametrelerindede yazili olmayan baska bir kural olarak, metod parametre sayisi 4'u geciyorsa buna onlem alinmasi gerekmektedir.
- Hazirladigimiz metod geriye deger donecekse mutlaka `return` ifadesi kullanilir.

```C#
static string TersCevir(string deger)
{
    string ters = "";
    for (int i = deger.Length - 1; i >= 0; i--)
    {
        ters += deger[i];
    }
    return ters;
}
// Parametre olarak string alan, ve aldigi bu stringi ters ceviren bir fonskiyon hazirladik
```

- Yazilan metod geriye bir deger donuyorsa, cagrildigi yerde o tipte bir degisken olur. Yani donen sonucu dogru veri tipine atamak gereklidir.
- Bir metoda parametre olarak dizi alabilirsiniz.

```C#
static string[] FirstLatterToUpper(ArrayList list)
{
    //string dizisi alip bu dizinin icindeki degerlin bas harflerini buyuk yapip geri donemlim
    string[] ModdedArray = new string[list.Count];
    var i = 0;
    foreach (var item in list)
    {
        ModdedArray[i] = char.ToUpper(item.ToString()[0]) + item.ToString().Substring(1);
        i++;
    }
    return ModdedArray;
}
```

- Metod, parametre alip ancak geriye deger donmeyebilir.

```C#
static void reverseArray(string[] list)
{
    string[] reversed = new string[list.Length];
    var index = 0;
    for (int i = list.Length - 1; i >= 0; i--)
    {
        reversed[index] = list[i];
        index++;
    }
    foreach (var item in reversed)
    {
        Console.WriteLine(item);
    }
}

string[] names = { "kasim", "cansu", "sahin", "selcuk", "ceylin", "pelin", "orhan" };

ReverseArray(names);
```

## ARA BILGI (SortedList Icine Bir ArrayList Ekleme)

Ornegin Ders ve sinif bilgisine gore ders konusu iceren bir sorted list

```C#

using System.Collections;

SortedList dersListesi = new();
dersListesi.Add("1.Sinif", new ArrayList() { "Turkce, Matematik, Tarih" });
dersListesi.Add("9.Sinif", new ArrayList() { "Fizik, Kimya, Edebiyat" });

static void DersListele(SortedList dersler, string sinif)
{
    // sorted list icinde key verip value alabiliyorduk
    ArrayList dersListe = (ArrayList)dersler[sinif];

    foreach (var item in dersListe)
    {
        Console.WriteLine(item);
    }
}

DersListele(dersListesi, "1.Sinif");
```

## Bir metod icinde baska bir metodu cagirmak

C#' ta bir metod baska bir metodu cagirabilir. Bunda bir sinir yoktur.

```C#
// bu metod parametre olarak aldigi key degerindeki value'lar ile bir arraylist hazirlayip onu geri donduruyor
static ArrayList Hazirla(string ders)
{
    SortedList dersler = new();
    dersler.Add("1.Sinif", new ArrayList() { "Turkce", "Beden" });
    dersler.Add("2.Sinif", new ArrayList() { "Turkce", "Matematik" });
    dersler.Add("3.Sinif", new ArrayList() { "Fizik", "Biyoloji" });
    dersler.Add("4.Sinif", new ArrayList() { "Kimya", "Tarih" });
    ArrayList liste = (ArrayList)dersler[ders];
    return liste;
}

// bu metod ise yukardaki hazirla metodunu calistiriyor. Ordan aldigi ArrayListi ekrana yazdiriyor. 
static void DersleriGetir(string ders)
{
    ArrayList liste = Hazirla(ders);

    foreach (var item in liste)
    {
        Console.WriteLine(item);
    }
}
```

> [**INDEX'e DON**](/README.md)
