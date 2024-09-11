# String İslemleri

string olarak yanımladığımız bir veriye bir metod uygulamak için değişkenin adını girdikten sonra (.) isareti ile metot çağırabiliriz.

* Ekrandan küçük harf ile aldığımız veriyi, hepsini büyük harfe dönüştürmek için **(toUpper)** metodunu calıstırırız.
* Ekrandan aldığımız büyük harfi olan bir veriyi tamamı kücük harfe dönüştürmek için **(toLower)** metodunu calıstırırız.
* Belirleyeceğimiz karakterlerin değişmesini istiyorsak bunu sağlamak için **(Replace)** metodunu kullanırız. Bu metot(fonksıyon) calısması için iki adet parametreye ihtiyac duyar, değiştirilecek karakter, yeni karakter.
```
    Console.WriteLine("Bir Metin Yaz");
    
    string metin = Console.ReadLine();
    
    metin = metin.ToUpper(); 
```

```
    metin = metin.ToLower();
```

```
    metin = metin.Replace("x", "");
```

* String metnin icerisinde bir karakterin olup olmadığını kontrol etmek icin `Contains` fonksiyonunu kullaniriz. Parametre olarak, char alır, çıktı olarak bool döner.
```
    bool isContains = metin.Contains("a");
    
    Console.WriteLine(isContains);
```
* Metnin baslangicinin belli bir karakter ve ya stringle olup olmadigini gormek icin `StartsWith` fonksiyonunu kullaniriz.
```
bool isStartsWith = metin.StartsWith("a");
System.Console.WriteLine(isStartsWith);
```
* Metnin bitisinin belli bir karakter ve ya stringle olup olmadigini gormek icin `EndsWith` 
```
bool isEndsWith = metin.EndsWith("n");
Console.WriteLine(isEndsWith);
```
* Sorgulanan karakterin metnin icinde en son gectigi noktanin *index* bilgisini (adresini) verir.
* Aranan deger metnin icerisinde yoksa sonuc -1 olacaktir.
* Coklu karakter girebiliriz. Metnin icerisinde bu karakter dizliminin son bulundugu yerdeki ilk index numarasi yazacaktir. 
```
int lastIndex = metin.LastIndexOf("a");
Console.WriteLine(lastIndex);
```
* Bir metnin icerisine istenilen baska bir metni ya da harfi eklemek icin `Insert` kullanilir. Iki parametre ister. Index bilgisi(nereye eklenecegini belirlemek icin) ve eklenecek ifade ve ya karakter.
```
string insertedText = metin.Insert(2, "wissen");
Console.WriteLine(insertedText);
```
* Bir metnin soluna ve ya sagina, ifadenin belirlenen karakter uzunlugunda olana kadar belirlenen hangi bir *char* eklemek icin `PadLeft` ve ya `PadRight` kullanilir. 
```
string paddedLeft = metin.PadLeft(20, '0');
Console.WriteLine(paddedLeft);
```
* Belirli bir index numarasindan sonrasini silmek icin `Remove` fonksiyonu kullanilir. Parametre olarak index girilir.
```
string removed = metin.Remove(5);
Console.WriteLine(removed);
```
* Bir metnin tamami yerine sadece belli bir kismini almak icin `SubString` kullanilir. Baslangic indexi ve uzunluk bilgisini parametre olarak alir.
```
string subString = metin.Substring(7, 20);
Console.WriteLine(subString);
```
* Bir metnin basindaki ve sonundaki bosluklari kaldirmak icin `Trim` kullanilir. Parametre yazilmasina gerek yoktur. Parametre olarak karakter girilerek o kadakterin de silinmesini saglayabiliriz. Sadece bastakini silmek icin `TrimStart` ve ya sondaki silmek istersek `TrimEnd`
```
string trimmedString = metin.Trim();
Console.WriteLine(trimmedString);
```