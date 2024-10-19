# partial class
Bir sinifin icindeki uyeleri farkli fiziksel dosya olarak tanimlanmasina imkan bir class cesididir.
Ornegin proplari bir dosyada, metodlara baska bir dosyada yazabilmemizi saglar.
> 1. dosya
```C#
public partial class Personel
{
    public int id { get; set; }
    public string name { get; set; }
    public double wage { get; set; }
}
``` 
> 2. dosya
```C#
public partial class Personel
{
    public void MaasAl()
    {

    }
    public void Calis()
    {

    }
}
```
* iki dosyadan olusan bu clasin tek bir dosya gibi davranmasini saglar,
* calistirma zamaninda nesne uzerinden eristigimizde bu iki parca dosya arkaplanda birlesip tek dosya gibi davranir
* partial class kod yazarken kolaylik olmasi icin vardir.