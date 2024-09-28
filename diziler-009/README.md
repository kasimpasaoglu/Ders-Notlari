# Diziler (Array)

Birden fazla ayni tipte veriyi tasiyabilen yapilara dizi(Array) denir
"Ekrandan 1000 adet not degeri aliniz" denildiginde normalde 1000 tane degisken tanimlayip her degeri bir degiskene girmek zorunda kalirdik.
Bir noktadan sonra bir suru degisken tanimlamak imkansiz hale gelir.
> 30 tane yumurtayi tasimak icin nasil yumurta kolisine ihtiyacimiz varsa, 100 tane int degerini tasimak icin de array'e ihtiyacimiz var.


:bulb: *syntax* => `int[] intDizisi = new int[1000]` => 1000 adet int degeri tasiyacak, adi intDizisi olan bir array tanimladik.

## Kurallar
1. Dizi tanimlanirken hangi tipi tasiyacagi belirtilmelidir. Dizi sadece tanimlandigi tipte veri icerebilir.
2. Dizi tanimlanirken kac adet veri tasiyacagi belirtilmelidir.
3. Dizilerin baslangic degerleri, onlarin kapasitesini belirler. Kapasite asimi yapilmaya calisilirsa runtime hatasi alirsiniz.
4. Dizi olusturulduktan sonra icine bir deger atanmazsa, dizi int dizisi ise, elemanlarin hepsi baslangicta 0 degeri alir. 
5. Dizilerde index numaralari 0'dan baslar.
6. var keyword'u ile dizi tanimlanabilir `var dizi = new dizi[10]`
7. Diziler bilincsiz tip donusumu yapabilir. Yani byte olan bir veri tipi int dizisi icindeki bir elemena atanabilir.
8. Dizi icinde olmayan bir indexe veri yazmaya ve ya almaya calisirsak runtime hatasi aliriz.

:warning: Dizi Tanimlarken [] isaretinin icine, dizinin kac elemanli olacagi bilgisi yazilirken, Dizi icindeki bir elemena ulasilmaya calisilirken, [] isaretinin icine index sayisi girilir.

## Dizinin Icindeki Elemana Ulasmak

```C#
    int[] intArray = new int[3];

    Console.WriteLine(intArray[1])// index1 e ulastik. Deger atamadigimiz icin 0 yazdi    
```
>koseli parantez icinde index numarasini vererek dizi icindeki elemana ulasilir.

## Dizi Icerisine Eleman Atamak

```C#
    int[] intArray = new int[3];
    intArray[1]=80; // 1. index elemanina 80 degeri verildi.
    Console.WriteLine(intArray[1]) // 80 degeri ekrana gelir  
```

## Dizi'nin butun elemanlarina erismek. (for dongusu)


> **Metod** `Lenght` dizinin eleman sayisini verir

```C#
int[] intArray = new int[10];

for (int i = 0; i < intArray.Length; i++)
{   
    // bu dongu dizinin boyutu kadar donecektir
    // 0. indexten baslayip dizinin uzunlugu kadar doner
    Console.WriteLine(intArray[i]);
}
```

### Ara Bilgi (Derleyiciyi Bekletme Fonksiyonu)
```C#
System.Threading.Thread.Sleep(milisaniye);
```
* Bu fonksiyon milisaniye cinsinden verecegimiz degere gore, derleyici bir sonraki satira gecmek icin bekleme yapacaktir

## Diziler Ile Birlikte Kullanilabilen Metodlar(Fonksiyonlar)
Diziler ile ilgili yapilacak islemleri yapan hazir fonksiyonlar vardir. Bu fonksiyonlara `Array` sinifi ile erisilebilir.
* `IndexOf()` array ve deger parametrelerini alir, o array icinde aradigimiz degerin hangi indexte oldugu bilgisini int olarak doner. `Array.IndexOf(arrayin adi, object deger)`
    * Aranan deger array icinde birden fazla varsa, ilk bulundugu indexi doner.
* `LastIndexOf()` array, ve deger parametrelerini alir. Aranan degerin gorundugu son index numarasini doner. 
* `Reverse()`  Parametre olarak arrayin adini alir
```C#
int [] reverseArray = new int[5]
reverseArray[0] = 100
reverseArray[1] = 52
reverseArray[2] = 75
reverseArray[3] = 40
reverseArray[4] = 80

Array.Reverse(reverseArray);
// arrayi burda yazdirirsak ters cevirdigini goruruz
```
>:warning: Aslinda reverse direk calisti, geriye birsey vermedi. Fonksiyonlar konusunda geriye birsey donmeyen fonksiyonlar ile ilgili konusacaz. Cumartesi gunu arada, isleyecegiz. Deger tip ve Referans tip konusu. 
* `Sort()` dizinin icindeki rakamlari kucukten buyuge, harfleri ise alfabetik siraya gore siralar. 
    * Parametre olarak arrayin adini alir. 
```C#
Array.Sort(reverseArray)
// yazdirirsak siralanmis hali gelir

```
* Kabarcik Siralama(Bubble)
* Hizli Siralama (Quick Sorting)
> ODEV: BOBBLE SORTING ILE 20 ELEMANLI BIR DIZIYI SIRALAYINIZ.
* `Clear()` Dizi icindeki tum elemanlar silinir. 
    * Parametre olarak array alir.
* `Copy()` Bir dizinin kopyasini olusturmak icin kullanilir. 
    * Alacagi parametreler sirasiyla; Kopyalanacak(kaynak) array, Kopyalanacagi (hedef) array, kacinci indexe kadar kopyalanacak
    * Copy metodu, belli bir index araligi ile de calistirilabilir.  
```C#
int [] reverseArray = new int[5]
int [] destinationArray = new int[5]
Array.Copy(reverseArray, destinationArray, reverseArray.Lenght)
// reverse arrayi destination arraye reverse arrayin lenghti kadar kopyala
```
```C#
string[] stringDizi = { "Ali", "Mehmet", "Alper", "Kasim", "Kerem" };
string[] newStringDizi = new string[15];

Array.Copy(stringDizi, 0, newStringDizi, 5, stringDizi.Length);
// stringDizi, 0.indexten itibaren kopyala, newStringDizinin 5. indexinden baslayarak, stringDizinin uzunlugu kadar eleman kopyala
```


### string - array iliskisi
String aslinda bir char dizisidir. Bu yuzden bir string degerin icinde `[]` isareti ile index girerek string degerin o indexteki karakterine ulasabiliriz. 
```C#
string metin = "wissen besiktas"

Console.WriteLine(deger[0]) 
// => 'w' karakterini yazdirir
Console.WriteLine(deger[2]) 
// => 's' karakterini yazdirir (2. index)
Console.WriteLine(deger[metin.Lenght -1 ]) 
// => 's' karakterini yazdirir (son karakter)
```
* Arrayden aldigimiz string bir degiskenin belli indexteki karakterinede ulasabiliriz. `dizi[2][4]` => dizi'nin 2. indexteki elemaninin, 4. indexteki elemani(karakteri)

## Farkli Tanimlama Sekillderi
* Hem tanimlayip hemde dizi elemanlarini verebiliriz
```C#
int[] dizi = new int[3]{1,2,3};
```
* Hem tanimplayip, hemde dizi elemanlarini verebiliriz
```C#
string[] stringDizi = {"Ali", "Mehmet", "Alper"};
```
Bu tip tanimada dizi buyuklugunu girmeye gerek yoktur. 
* `var` ile tanimlanimlanabilir
```C#
var boolDizi = new bool[] {true,false,true,true};
```
`var` ile tanimlarken sag tarafinda tip belirtmemiz gerekir, cunku `var` dizi icin kullanildiginda, derleyicide tipin ne oldugunu algilayamaz 

# Queue Dizisi

* Icerisinde tutulan degerlerin object olarak tutuldugu bir dizidir.
* Queue kuyruk (sira) mantigi ile calisir. (Akbil, Pide, Otobus kuyrugu gibi)
* queue dizisi kullanabilmek icin, programin en basina `using System.Collections;` komutu girilmelidir
    * 

`Queue queueDizisi = new Queue();`

* `Enqueue` Metodu, ile diziye eleman yerlestirildir. 
```C#
queueDizisi.Enqueue("Renault")
queueDizisi.Enqueue("Mercedes")
queueDizisi.Enqueue("Audi")
queueDizisi.Enqueue("BMW")
```
* `Count` metodu ile dizinin eleman sayisini bilabiliriz
* `Peek` metodu, kuyruktan cikacak ilk elemani verir, yani en on siradaki kim sorusuna cevap veriyor. Ancak queue dizisinde bir degisiklik yapmadi
```C#
string first = queue.Peek().ToString()
// queue elemanlari obje olarak tuttugu icin unboxing yapilmali,
// bu yuzden ToString() kullandik
```
* `Dequeue` metodu, hem kuyruktan cikarilacak ilk elemani dondurur, hemde kuyruktan cikarir.

:warning: Diziler ile Kolleksiyonlar arasindaki en temel fark; kolleksiyon tanimlarken baslangic degeri vermek zorunlu degildir.

Yarin Stack yapisi incelenecek. 
Stack, Queue dan farkli olarak last in first out, yani tersten cikis yapilir, prensibiyle calisir. (LIFO)