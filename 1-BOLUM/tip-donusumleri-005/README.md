# Table Of Contents

- [Tip Donusumleri](#tip-donusumleri)
  - [Convert](#convert)
  - [Parse](#parse)
    - [C# ile Random Sayi Olusturma (Ara Konu)](#c-ile-random-sayi-olusturma-ara-konu)
    - [ToString](#tostring)
    - [Cast](#cast)
      - [Implicit Tip Donusumu (Bilincsiz)](#implicit-tip-donusumu-bilincsiz)
      - [Explicit Tip Donusumu (Bilincli)](#explicit-tip-donusumu-bilincli)

# Tip Donusumleri

C#'da 4 turlu tip donusumu vardir

1. Convert
2. Parse
3. ToString
4. Cast

## Convert

C# ta kullanilan build-in(onceden tanimli) 15 adet veri tipini birbirine donusturmek icin kullanilir.
Syntax: int intOlarakDonecekDeger = Convert.ToInt32(intTipineDonusecekDeger)

```C#
    Console.WriteLine("Lutfen bir sayi girin :");
    
    string userInput = Console.ReadLine();
    int convertedUserInput = Convert.ToInt32(userInput);
    
    convertedUserInput *= 2;
    Console.WriteLine(convertedUserInput);
```

Ornek; Kullanicinin yazdigi sayinin tek mi cift mi oldugunu ekrana yazan bir program yazalim

```c#
    Console.WriteLine("Sayi Girin :");
    int userInput = Convert.ToInt32(Console.ReadLine());
    
    int modUserInput = userInput % 2;
    
    bool isNumberOdd = modUserInput == 1;
    
    Console.WriteLine("sayi tek mi?  " + isNumberOdd);
```

- Convert ile birlikte sadece `ToInt32` degil, baska donusumler de yapabilir `ToDouble` gibi  
- bool veri tipini inte donustururken 0 ve ya 1 doner. int veriden boola donerken, 0 disinda bir deger varsa her zaman true doner.
- char tipi int tipine donustugunde her bir harfe karsilik gelen bir rakam kodu vardir, o rakama doner (0 ile 255 arasi). Tam tersini de yapabiliriz rakamin harf karsiligini verir.
- string veri icinde rakamlarda varsa ve inte cevirirsek harfleri kaldirip sadece rakamlari birakir.

## Parse

Sadece string icin ozellesmis bir tip donusumudur.
**Parse** string tipindeki verileri diger tiplere donusturmek icin kullanilir, yani sadece string alir.
Syntax = `(donusturulecekTip).Parse(string veri)`

```C#
    string = metin "10";
    int intDegisken = int.Parse(metin);
```  

- string veri tipi C#'ta cok fazla kullanildigi icin, gelistirilmis bir metodtur. Amaci stringi hizlica (pratik) baska bir veri tipine donusturmektir
- Yazilimda kullanicidan alinan butun veriler/degerler string olarak gelir. Bu yuzden string cok kullanilan ve ozel bir veri tipidir.

### C# ile Random Sayi Olusturma (Ara Konu)

- Belirli bir aralik vererek ve ya vermeyerek C# in rasgele bir sayi vermesini saglayabiliriz.
- simdilik sadece syntax i ezberleyelim. aciklamasini sonra...

```C#
    // random bize rakamsal degerlerin sinirlari icerisinde random bir deger uretip verecektir.
    Random rnd = new Random();
    int intRandom = rnd.Next();
```

```C#
    Random rnd = new Random();
    //next fonksiyonu icerisinde iki deger girip bu iki deger arasinda bir deger donmesini saglariz
    int randimInt = rnd.Next(1,5);
```

- Double tipinde bir random olusturabiliriz. Ancak `NextDouble` metodu bir parametre almaz, aralik belirlemek icin sonucu carpariz. Yani sadece ondalikli kismi olusturur.

```C#
    Random rnd = new Random();
    double randomDouble = rnd.NextDouble();
```

## ToString

ToString tip donusumu, parse donusumunun tersi olarak calisir.

- Parse string tipinden diger tiplere donusum yaparken, ToString diger tiplerden string tipine donusum yapar.
- degistirmek istedigimiz degiskenin sonuna `.ToString()` fonksiyonu cagrilarak kullanilir.

```C#
    int intDegisken = 10;
    string stringDegisken = intDegisken.ToString();
```

- **Dipnot 1**, `WriteLine` metodu biz icine "" ekleyip veriyi string olarak yazmasakta, WriteLine metodu `ToString` basar.

- **Dipnot 2**, `WriteLine` yerine sadece `Write` yazarsak bir alt satira inmez, ayni satira yazar.
- **Dipnot 3**, `Random()` fonksiyonu char deger de alabilir. `rnd.Next('a', 'z')` ile harf araligi girilebilir.  

## Cast

Cast tip donusumu ikiye ayrilir.

1. Implicit Tip Donusumu (Bilincsiz Tip Donusumu)
2. Explicit Tip Donusumu (Bilincli Tip Donusumu)

### Implicit Tip Donusumu (Bilincsiz)

```C#
    byte byteDegisken = 10
    int intDegisken = byteDegisken
    // byte tipindeki degisken int tipine donusturuldu.
```

- Implicit tip donusumde kucuk tip buyuk tipe donusturuluyorsa, buyuk tip kucuk tipi tasiyabileyecegi icin bu donusum C# tarafindan yapilir, ekstra birsey yazmaya gerek kalmaz.

### Explicit Tip Donusumu (Bilincli)

- Buyuk veri tipini kucuge donustururken derleyici burda veri kaybi olabilecegi icin bizden onay ister, dogrudan donusum yapmaz. Bu yuzden **syntax** yazmak gereklidir. Denedigimiz zaman, Bilinciz olarak bunu donusturmem yazar.

```C#
    int intDegisken = 10;
    byte byteDegisken = (byte)intDegisken;
    // int tipi byte'a donusturuldu.
```

- Eger buyuk olan veri donusturulmeye calistigi veriye sigmayacak kadar buyukse veri sizmasi olur.

```C#
    int intDegisken = 300;
    byte byteDegisken = (byte)intDegisken;
    // bu durumda byte siniri 255 oldugu icin, 300'un 255 e gore modunu aldi 
    // ve sonuc olarak ekrana 44 yazdirdi. Veri bozulmus oldu.
```

- Son ornekten gorundugu uzere; ufak bir tip donusumu bile yazilimda beklenilen degerlerin disinda bambaska bir deger cikmasina sebep olur. Bu yuzdden **cast asla bilincsiz bir sekilde kullanilmamalidir**
- cast yontemi ile **bool => int** donusumu yapilamaz.
- cast yontemi ile string tipi bir tipe donusturulemez.
- Convert C# ta onceden tanimli olan 15 adet tipi birbirine donusturmeye yarar
- Cast ise hem bu 15 tanimli tipi birbirine cevirir(String istisna), hem de ileride gorecegimiz (kendi tipimizi yazma konusunda), diger tipleri de birbirine donusturur.

> [**INDEX'e DON**](/README.md)
