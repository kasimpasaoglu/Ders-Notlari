# Properties yontemi ile Encapsulation
* getter ve setter metodlarini uzun uzun yazmak is yukunu ve hata yapilmasi ihtimalini arttirdigi icin, zamanla C# muhendisleri tarafindan gelistirilmis bir diger encapsulation yontemi proterties yazmaktir.
```C#
public class Personel
{
    // eger bir sinifin degiskeniysen adin field'tir
    // eger metodun degiskeni ise adi degiskendir. 
    private int id;
    private string name;
    private int age;
    private int maas;
    // 3 adet degisken icin 3 adet property yazilacak
    public int Id
    {
        get{return this.id;}
        set{this.id = value;}
    }
    public string Name
    {
        get{return this.name;}
        set{this.name = value;}
    }
    public int Age
    {
        get{return this.age;}
        set{this.age = value;}
    }
        public int Maas
    {
        get {return this.maas;}
        set { this.maas = value;}
    }
}
```
* get ve set adinda 2 metodu tek bir proterty icine aldik.

> * Personel nesnesindeki id isimli propertiese eriserek deger atadik,
> * Id, isimli proterties'de nesne icerisindeki private olan id fieldina deger atamasi yapariz. 
> * Proplar uzerinden get ve set yapmak kolaydir. Ilk ogrendigimiz yontem gibi, sanki gorudan erisiyormus gibi davranarak get ve set yapabilir.
```C#
Personel p = new();
p.Age = 30;
Console.WriteLine("Yas : {0}", p.Age);
```
## `private get` ve ya `private set` Olarak Yazma
* Property yazarken set ya da get degerlerini kapatabiliriz.
* Yani `readonly` bir property yazabiliriz. Get metodu calisir ancak set metodu olmaz.
* ve ya `setonly` olarak yazmak isteyebiliriz. 
* Bunun ici iki yontem vardir, ya saklamak istedigimiz metodun onune private keywordu eklemek, 
* ya da istemedigimiz blogu tamamen kaldirabiliriz
```C#
    public int Id
    {
        get { return this.id; }
        private set { this.id = value; }
    }
```
ve ya

```C#
    public int Id
    {
        get { return this.id; }
    }
```
## Calculated Proterty
* Bu yontemde propery bir degeri koruma altina almaz sadece hesaplanmis degeri doner.
```C#
    public int Maas
    {
        get {return this.maas;}
        set { this.maas = value;}
    }
    public double ZamliMaas
    {
        get {return this.maas * 1.7;}
    }
```
Erismek icin
```C#
p.Maas = 3000; // maas degerini atadik
Console.WriteLine("Yeni Maas : {0}", p.ZamliMaas); // zamli maasi ekrana aldik.
```

