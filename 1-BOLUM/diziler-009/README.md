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
Bu orneklerde tanimladigimiz dizilerde sonradan buyutme sansimiz yoktur. Biz veri ekledikte buyuyebilen diziler icin `Collections` kullanacagiz...

## Queue Kolleksiyonu

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

:warning: Diziler ile Kolleksiyonlar arasindaki en temel fark; kolleksiyon tanimlarken baslangic degeri vermek zorunlu degildir. Eleman eklendikce kapasitesini arttirir

## ARA KONU (NameSpace - IsimUzayi)

:bulb: Programlamada baslangic asamasinda ekstra hic bir kutuphane kullanmamiza igtiyac yoktur. Ancak Ilerleyen noktalarda bazi kutuphanelere ihtiyac duyariz. Bu kutuphaneler disaridan indirilen kutuphaneler olabilecegi gibi .net'in kendi icinde bulunan kutuphaneler olabilir.
**NameSpace** aslinda, ayni isimde olan tipleri birbirinden ayirmak ve icinde tutmak icin vardir.
Mesela Queue kullanmak icin Collections kutuphanesine ihtiyacimiz vardi.
`using System.Collections;`
Bu namespace'leri cagirmak icin using ifadesi kullanir. Kodun en basina yazilmalidir.

## Stack Kolleksiyonu

* Bircok kolleksiyon gibi, Stack'te object deger alir.
* queue gibi yine sira mantigi ile calisir, ancak burda Last In First Out,(LIFO) duzeni uygular. Yani stackten oge cikarmaya basladigimizda en son eklenen ogeyi ilk cikaracak, (index en buyukten baslayarak cikarmaya baslar)(Tir dorsesi ornegi).
* `Push` fonskiyonu ile eleman eklenir

 ```C#
 Stack stackDizisi = new Stack();

 stackDizisi.Push("Yuk 1");
 stackDizisi.Push("Yuk 2");
 stackDizisi.Push("Yuk 3");
 stackDizisi.Push("Yuk 4");
 stackDizisi.Push("Yuk 5");
 stackDizisi.Push("Yuk 6");
 stackDizisi.Push("Yuk 7");
 ```

* `Peek` metodu listede silinecek olan (sirada olan) itemi dondurur, ancak silme islemini yapmaz
* `Pop` metodu listede silinme sirasi gelen itemi hem siler, hem dondurur.
* `Count` metodu ile eleman sayisi ogrenilir

## Array List

* Icine object deger alan bir kolleksiyondur
* `Add` metodu ile eleman eklenir.
* `Count` metodu icindeki eleman sayisini dondurur.
* `Capacity` metodu alabilecegi maksimum eleman sayisini belirtir
  * Eleman eklendikce artmaktadir.
  * ArrayList in kapasitesi 4 ten basayarak eleman eklendikce, katlanarak artak (4-8-16-32).
* ArrayList icindeki bir ogeye erismek icin normal arrayde oldugu gibi [] ile index verilir ve unboxing yapilmalidir.
* ArrayList Tanimlanirken parametre olarak kapatite belirtilebilir

### Kolleksiyonlarla Birlikte Kullanilabilecek Hazir Metodlar

`ArrayList liste = new ArrayList()` Ile hazirladigimiz bir kolleksiyon ile

* `Clear()` Kolleksiyon icindeki verileri siler
* `Sort()` ogeleri siralar
* `Reverse()` kolleksiyonu ters cevirir
* `ToArray()` kolleksiyonu diziye donusturur
* `Contains("")` kolleksiyon icinde arama var, parametrede verilen deger varsa true doner(bool)
* `Insert()` kolleksiyon icinde belli bir yere veri eklemek icin kullanliri, Iki Parametre alir, ilki index bilgisi, ikincisi verinin kendisi.
`GetRange()` Kolleksiyon icerisinden birden fazla veri getirmek icin kullanilir. Verinin gelecegi index ve bu indeksten sonra kac index veri getirilsin parametreleri ile calisir.
* `TrimToSize()` Kolleksiyonlarda count ve capacity 'i birbirine esitlemek icin kullanilir.
  * Ornek count :5, capacity 8 ise capacity'i 5 yapar.

## SortedList Kolleksiyonu (Sirali Liste)

Bu gune kadar gordugumuz kolleksiyonlardan farkli olarak, **key** ve **value** bilgisi tasirlar.

```C#
SortedList sortedList= new SortedList();

sortedList.Add(1, "Ali");
sortedList.Add(9, "Hande");
sortedList.Add(6, "Elif");
sortedList.Add(7, "Selcuk");
// key olarak ogrenci numarasi, value olarak isim girdik
```

* SortedList oge eklerken, Add fonskiyonu, key ve value, parametrelerini ister. Bu parametreleri object olarak aldigi icin her turlu degeri verebiliriz.
* SortedList ogeleri **key** degerine gore siralayarak, saklar. Key degeri sayisal bir degerse, kucukten buyuge dogru, harf ise alfabetik siraya gore siralar.

```C#
for (int i = 0; i < sortedList.Count; i++)
{
    string value = sortedList.GetByIndex(i).ToString();
    Console.WriteLine(value);

    string key = sortedList.GetKey(i).ToString();
    Console.WriteLine(key);
}
```

* `GetByIndex()` Metodu ile index girerek o indexteki **value** degerine ulasabiliyoruz,
* `GetKey()` Metodu ile index girerek o indexteki **key** degerine usalabiliyoruz

* Bu kolleksiyon key ve value olarak 2 ayri deger tuttugu icin `Contains()` fonksiyonu iki tanedir.
  * `ContainsKey()` **key**'ler icinde arama yapar.
  * `ContainsValue()` **value**'lar icinde arama yapar.
* Key degeri unique olmalidir, ayni key degeri birden fazla ogeye verilmez. (Calisma Zamani Hatasi verir)

:warning: Kolleksiyonlar konusuna bir sure ara veriyoruz, Generic Kolleksiyonlar konusuna geldigimizde tekrar kolleksiyonlar konusuna devam edecegiz.

> [**INDEX'e DON**](/README.md)
