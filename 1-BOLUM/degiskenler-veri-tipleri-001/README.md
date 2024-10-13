# Hazirlik & Giris

Dotnet’i indirdikten sonra vscode icinde `dotnet new list` komutunu yazarak templateleri listeledik. (Tample projenin ana yapisi)

Baslangicta Console Application’u sececegiz. Bu sayede gorsellerle ugrasmadan sadece kod yazmayi ogrenecegiz. Bu template ile hazirladigimiz uygulamalar terminalde calisacak.

Console Application’u olusturmak icin ikinci sutundaki short name bolumune bakip `dotnet new console` yaziyoruz ve dosya yapimiz olusuyor.


# Degiskenler

Bir yazilimda, yazilimin icine deger girme uc sekilde olur.

1. Kullanicidan deger alma
2. Direk degeri yazilimin icine girmek
3. Degeri bir veri kaynagindan cekmek (veri tabani)

Her 3 senaryoda da, yazilim bir sekilde veriye ulasir

Yazilim icerisindeki her turlu veri, eger bir veri kaynagi yoksa (vertabani) tum verileri memory’de (RAM) tutar.

Bir veri alinirken ve ya yazilirken once **tip**’ine karar veririz. C# sharpta yaklasik olarak 15 adet veri tipi vardir.

![Veri Tipleri](https://www.kodyaz.net/wp-content/uploads/2016/08/c-sharp-degiskenler-temel-veri-turleri.jpg)

Not:Ayrica bu resimde olmayan **bool (boolean)** veri tipi vardir. Genelde mantiksal islemler icin kullanir. **true ve ya false** bilgisini tutar. **2 byte** yer kaplar.

--- 

Bu sekilde veri tiplerini siniflandirmamizin sebebi, girecegimiz her bir degisken icin memory(RAM)'de ne kadar alan ayrilmasi gerektigini belirlemek icindir.\
En optumum yazim icin her bir veri buyuklugunu uygun veri tipiyle memory'e yazmak gerekir.\
*Ornegin; **18** rakamini **int** veri tipi ile yazarsak 3 byte fazladan memory'de yer kaplamis olacak cunku 18 aslinda **byte** veri tipine sigacak kadar kucuk bir veridir. Ancak biz onu **int** icine yazarak 4 byte yer kaplamasina sebep oluruz.*\
Tabi ki guncel bilgisayarlarin islem gucu goz onune alindiginda bu kadar mikro olcekli dusunmemize gerek kalmiyor, cunku mevcut bilgisayarlarin RAM kapasitesine gore artik byte 5-10 btye in cok buyuk bir onemi yok. Bu yuzden derste yapacagimiz calismalarda cogu zaman butun sayilari **int** olarak tanimlayip gececegiz.\

## Degisken Tanimlama Kurallari
* Degisken isimlendirilirken, turkce karakter kullanilmamalidir
* Degisken isminde, bosluk olmamalidir
* Degisken ismine, kesinlikle rakam ile baslanmaz
* Degisken ismi, iki kelimeden olusacaksa `camelCase` sekildine yazilmalidir. Tamami buyuk yazilmamalidir. Sadece tek kelimelik degisken isimlerinde tamami kucuk yazilmalidir. (or; `wissenBrightBesiktas`) (ilk kelimenin bas harfi kucuk ikinci ve sonraki kelimelerin ilk harfleri buyuk yazilmalidir)
* Degisken isimlendirilirken, cok uzun isimler kullanilmamalidir
* Degisken, tasidigi deger ile ilgili isimlendirilmelidir. 
* Degisken isimlendirilirken asla anlamsiz isimler verilmemelidir ('x', 'asd')
* Degisken isimleri birbirinden farkli olmalidir. 
* Degisken tanimlarken syntax asagidaki sekilde yazilmalidir. \
`degisken tipi (bosluk) degisken adi = degiskenin degeri;` \
*Ornek;* 
```
    int intDegiskeni = 8; 
    byte byteDegiskeni =244;
    decimal ondalikDegisken = 9.7M; 
    char charDegiskeni = 'E';
```
## Matematiksel Islemler ( +, -, *, /, %,)
Console.WriteLine icerisinde matematiksel islem yapilabilir. 
```
    int birinciSayi = 10;
    int ikinciSayi = 35;

    Console.WriteLine(birinciSayi + ikinciSayi)

    // Bu islem 45 sonucunu ekrana yazar. 
```
Bu ornekler (+,-,*,/,%) operatorleri ile cogaltilabilir. 

***NOT***
* '+' operatoru iki matematiksel veriyi birbiri ile toplar
* ancak '+' operatoru iki metinsel veriyi birbiri ile birlestirir.
Ornek;
```
string wissen = Wissen
string besiktas = Besiktas

Console.WriteLine(wissen + besiktas)
// cikti: WissenBesiktas
```
* metinsel veri ile rakamsal veri arasindaki '+' operatoru birlestirme islemi yapar. 
ornek;
```
Console.WriteLine("Toplam :" + birinciSayi + ikinciSayi )
// cikti: Toplam : 1035
```
Araya bir string ifade girdigimiz icin artik toplama islemi yapmiyor birlestirme yapiyor.

* bir değişkeni tanımlamadan daha sonra tanımlacak sekilde açık bırakabiliriz `sting city;`
* tanımlamayı başka bir satırda yapabiliriz. `city = "Istanbul"`
* Birden fazla tanımlama aynı aynda yapılabilir
```
   int birinciDegisken,ikinciDegisken,ucuncuDegisken;

   birinciDegisken = 50;
   ikinciDegisken = 60;
   ucuncuDegisken = 70;
```
* Bir değişkene farklı zamanarda birden fazla değer atanırsa her zaman en son satırda atanan değeri taşır.
* farklı tiplerdeki verileri farklı tip değişkenlere atarsak
* C# dilinde iki tip hatayla karşılaşabiliriz.
1. Derleme hatası (syntax) farklı tiplerdeki verileri farklı tip değişkenlere atarsak derleme hatası olur
```
int stringAtananInt = "int tipine string vermek";
```
2. Mantık hatası (Kod yapısal olarak doğru yazılmıs ancak )kodun çalışma mantığında hatalar olduğu için doğru çalışmıyor.

* boyut farkından dolayı byte tipine int atayamayız. int verisi byte ın icine sığmaz. Burda derleyici hata verir, onay ister. 
```
    byte byteAtanacak;
    int ıntAtanmis = 100;

    byteAtanacak = intAtanmis;
    //hata
```

* Eger şartlar uygun ise C# tip donusumunu otomatık yapar. Yani aynı tip veriyi ve ya daha kücük olan veri tipini daha büyük veri tipine atayabiliriz. derleyici tip dönüştürme işlemini kendi kendine yapar.
```
    int buyukSayı ;
    byte kucukSayı = 155;

    buyukSayı = kucukSayı;
```
***NOT: bilinçli ve ya bilinçisiz tip atamalarını, tip dönüşümlerinde daha detaylı göreceğiz.***

> [**INDEX'e DON**](/README.md)