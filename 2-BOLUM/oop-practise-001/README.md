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
:bulb: bu sekilde this keywordu alan degerler classa ait olan degeri temsil eder, yani class nesnesi olan id ye parametre olarak gelen id'yi atamis olur.
