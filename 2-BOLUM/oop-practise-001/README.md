* Bazen ctor olustururken, ctor'a gelen parametreler ile class degiskenleri ayni isim olabilir. Bu Bir sorun olacagi icin, ctor parametrelerini farkli isimlendirebiliriz.
```C#
public class Product
{
    public int id ;
    public string name;
    public decimal price;
    public Product(int id, string name, decimal price)
    {
        id = id;
        name = name;
        price = price;
    }
}
``` 
:bulb: bu sekilde atama yaparken degerler ayni oldugu icin hangi id ye hangi idyi verecegini bilemez.
* Farkli isim vermek istemiyorsak, `this` keywordu kullanabiliriz. 
```C#
    public Product(int id, string name, decimal price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
    }
```
:bulb: bu sekilde this keywordu alan degerler classa ait olan degeri temsil eder, yani class degeri olan id'ye, parametre olarak gelen id'yi atamis olur.
## Birden fazla ctor kullanimi
* Bazen nesneyi farkli bilgiler ile bellege cikarmak isteyebiliriz, 
    * Sadece ad vererek
    * Sadece soyad vererek
* Bu islem icin ctorlari birbirine yonlendirme islemi yapabiliriz,
* Bir ctor calismaya baslamadan once baska bir ctora yonlendirebilir ve o ctorun calismasi bittiken sonra , istedigimiz ctor'u calistirabiliriz
* Bu islemi ctorlar arasi parametre gondererek yapabiliriz.
* ctor'un parametre alanina `:this(degisken)` syntaxi ile yonlendirme yapilabilir.
Ornek : [Ogrenci.cs](/Ogrenci.cs)