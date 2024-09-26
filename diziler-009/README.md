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
```C#
int [] reverseArray = new int[5]
int [] destinationArray = new int[5]
Array.Copy(reverseArray, destinationArray, reverseArray.Lenght)
// reverse arrayi destination arraye reverse arrayin lenghti kadar kopyala

```