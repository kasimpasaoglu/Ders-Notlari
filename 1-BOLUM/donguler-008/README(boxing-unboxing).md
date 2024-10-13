# Boxing / Unboxing

Değişken tiplerinin birbirini kapsaması yada kapsayamaması konusudur.

Bizim bu asamada bilgisimiz 15 adet degisken tipi vardir.

Birde .Net icinde tum tiplerden daha ustun(kapsayici) olan bir tip vardir `Object`

`Object` .Net Icerisindeki onceden tanimli olan ve ilerde kendi yazacagimiz butun tipleri kapsar

Ozetle : C#'in en tepedeki tipi object'dir.

* C#'ta su ana kadar kullandigimiz tip cesitleri **deger tip**'ti
```C#
    int a = 10;
```

* Ayrica henuz ogrenmedigimiz fakat bir kac ornegimizde kullandigimiz bir tip cesidi daha vardi. O da: **referans tip**'ti
```C#
    Random rnd = new Random()
```

    * Referans tipler de kendi icinde ikiye ayrilir daha sonra ogrenecegiz.

## Object

Tum Bu tipleri kendi icerisinde tutabilir
```C#
    object o = 10;
    // object tipinde bir degisken int tipinde bir degeri tasidi

    object o1 = "Merhaba";
    // object tipinde bir degisken string tipinde bir degeri tasidi

    object o2 = 'A';
    // object tipinde bir degisken char tipinde bir degeri tasidi

    object o3 = true;
    // object tipinde bir degisken bool tipinde bir degeri tasidi
```

* Peki `object` bu kadar kapsayiciysa diger tiplere neden ihtiyac duyariz?
```C#
    object o5 = 10;

    object o6 = 50;

    Console.WriteLine(o5 + o6);
```
>iki adet int degeri object tipine verdik. ancak object tipinde + operatoru kullanilamaz diye hata aldik. 
* Cevap : degiskenler uzerinde islem yapilacaksa `object` kullanilamaz.

* object bir veriyi bir yerden bir yere tasimak icin kullanilir. Yani `object` aslinda bir kutu gibi dusunebiliriz.
* Bir veri alirken, ornegin ilerde kendi fonksiyonlarimiizi yazarken, bu fonksioynun calismasi icin parametreler isteyecegiz. Gelen parametrelerde her bir veri tipi icin ayri kod bloklari yazmak yerine object ile bu parametreleri butun tiplerden girdiyi kabul edecek sekilde yapariz.

```C#

int a =10; // 10 degerini tasiyan bir int degiskenimiz var

object o7 = a; // bu degiskenimizini o7 object'ine koyuyoruz.
```
>Bu islemin adi `boxing`'tir

* Bu sekilde `boxing` yapilan veri tipini tekrar kullanmak icin, bir degiskene atayabiliriz.(*kutusundan cikarmak*)

```C#
int b = (int)o7;
```
>Bu islemin adi `unboxing`'tir

* :warning: Objenin icine atilan degisken tipini disari cikarirken ayni tip ile cikarmak gerekir. Once ayni veri tipi ile cikilir, sonra tip degisimi yapilmalidir
```C#
    int a = 10;
    object o7 = a;
    int b = (int)o7;

    byte c = (byte)o7; 
    // bu satir hata verir, cunku boxing int olarak yapildi.

    byte c = (byte)(int)o7;
    // bu sekilde once int olarak cikarip sonra byte tipine ceviririz
```

**:warning: Bu konuyu simdilik burda birakiyoruz, ilerleyen konularda daha sik kullanip daha iyi anlayacagiz.**