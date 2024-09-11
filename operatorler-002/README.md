# Operatorler

## Matematiksel Operatörler

(+,-,*,/,%)

Degişkenleri kullanarak toplama çıkarma çarpma bölme ve mod alma işlemi yapalım

## Mantıksal Operatörler

(>,<,<=, >=, &&,||, ==, !=)
Bütün mantıksal operatörler evet/hayır sorusuna cevap verir. Bu yuzden mantıksal operatorler her zaman bool tipinde *true* ve ya *false* döner. *Örnek:*
`bool isOkay =false;` 
* bool tipi true ve ya false dısında bir değer alamaz.
* (>) Büyükse true döner, (>=) büyük ve eşitse true döner
* (<) Küçükse true döner, (<=) küçük ve eşitse true döner
* tek (=) isaretini atama yapmak icin kullanmıstık. İki esittir (==) ise esitse true doner.
* (!=) Esit değilse true döner
* (&&) ve anlamına gelir. İki kosulun ikisinin de doğru olması gerekir.
* (||) ve ya anlamına gelir. İki kosuldan herhangi biri doğruya true döner.

### Buyuk,Kucuk,Esit operatorleri
```
    int buyukSayi = 100;
    int kucukSayi = 8;
    
    bool kucukMu = kucukSayi < buyukSayi;
    bool buyukMu = kucukSayi > buyukSayi;
    bool esitMi = kucukSayi == buyukSayi;
    bool esitDegilMi = kucukSayi != buyukSayi;
    
    
    Console.WriteLine(" {0}, {1}'den kücük mü  :  {2}", kucukSayi, buyukSayi, kucukMu);
    Console.WriteLine(" {0}, {1}'den büyük mü  :  {2}", kucukSayi, buyukSayi, buyukMu);
    Console.WriteLine(" {0} esit mi {1} :  {2}", kucukSayi, buyukSayi, esitMi);
    Console.WriteLine(" {0} esit değil mi {1} :  {2}", kucukSayi, buyukSayi, esitDegilMi);
```
### ve (&) operatoru
* Bu operator kullanıldıgında sorgulanan bütün kosulların sağlanıp sağlanmadığına bakar. Sadece bütün koşullar sağlandığında true döner.
```
    string veriTabanindakiUserName, veriTabanindakiPassword, kullanicidanGelenUserName, kullanicidanGelenPassword;
    
    veriTabanindakiUserName = "root";
    veriTabanindakiPassword = "2020";
    
    kullanicidanGelenUserName = "wissen";
    kullanicidanGelenPassword = "1010";
    
    bool girisOk = kullanicidanGelenUserName == veriTabanindakiUserName && kullanicidanGelenPassword == veriTabanindakiPassword; 
```
* true && false => false
* **true && true => true**
* false && false => false
* false && true => false

### ve ya (||) operatörü.
* Kosullardan herhangi biri true olması sonucu true döndürmesi için yeterlidir. Kaç tane false olmasının bir önemi yok. Şartlarda tek bir true varsa. Hepsinin true dönmesine gerek yok.
```
    bool girisOrOk = kullanicidanGelenUserName == veriTabanindakiUserName || kullanicidanGelenPassword == veriTabanindakiPassword;
```
* true && false => true
* true && true => true
* **false && false => false**
* false && true => true

### Aynı anda hem (&&) hemde (||) operatorlerının aynı anda kullanılması.
İslem önceliklerini belirlemek icin **parantez** kullanırız. (Normalde bir işlem önceliği var zaten ama biz garantiye alıyoruz)
```
    int sayi1 = 4;
    int sayi2 = 5;
    int sayi3 = 6;
    int sayi4 = 10;
    int sayi5 = 54;
    int sayi6 = 5;
    int sayi7 = 9;
    
    bool result = (sayi1 != sayi4 && sayi2 == sayi6) || (sayi4 < sayi5 || sayi3 >= sayi7);
```
## Atama Operatorleri
Bir değişken tanımlayıp bu değişkene bir değer verip bu değeri 1 arttılarım
```
    int degisken = 10
    degisken = degisken +1 
```

Bu yöntem çalışıyor olsa bile pratik değil. 
Bunu daha pratik yapmak için bazı operatörlerden yararlanabiliriz.
### Arttırma Operatörü

```
    int degisken = 10;
    degisken += 1;
```

Bir değişkenin değerini diğeri kadar arttırmak icin
```
    int birinciDegisken = 10;
    int ikinciDegisken = 80;
    
    birinciDegisken += ikinciDegisken;
```
burda birinci degisken 90 olarak döner artık. Yani ikinci degiskeni birinci degiskenin üstüne eklemiş olduk. Yani birinciDegisken degerini değiştirdik. \
Cıkarma çarpma bölme işlemleri aynı şekilde yapabiliriz.
``` 
    int birinciDegisken = 10;
    birinciDegisken -=5;
```
```
    int birinciDegisken = 10;
    birinciDegisken *=5;
```
```
    int birinciDegisken = 10;
    birinciDegisken /= 5;
```

### Atama Operatörleri (++, --)
Bır degiskene hızlıca 1 arttırmak ya da 1 eksiltmek icin kullanılır. 

```
    int deger=0;
    deger++;
    deger--;
```

* ++ ve ya -- operatörü degiskenin basında yazılırsa ne değişir.

```
    int deger = 0;
    int sonuc = deger++;
```
* Bu sekilde yazılırsa once atama sonra arttırma yapılır. Yani önce deger degiskenini sonuc degiskenine yazar. sonuc = 0 olur sonra degeri 1 arttırır. Yani sonuc bu örnek için istediğimiz gibi gelmez.
* Ancak once arttırmayı sonra atamayı yapmasını ıstıyorsak ++ ve ya -- operatorunu degiskenin soluna atılması lazım. 
```
    int deger = 0;
    int sonuc = ++deger;
```