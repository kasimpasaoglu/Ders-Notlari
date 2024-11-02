# Generic Class

Bir classin ozelliklerini generic yapabiliriz

```C#
public class Ogrenci<T, K, M>
{
    public T TProp { get; set; }
    public K KProp { get; set; }
    public M MProp { get; set; }

    public M GenericMetod1(M value1, M value2)
    {
        return default(M);
    }
}
```

- T,K,M generic degerlerini sinif nesne ornegi olustururken verilecek.
- sinifa ait elemanlar bu generic tipler ile olusturulabilir.

- `Ogrenci<int,string,byte> o = new Ogrenci<int,string,byte>();`
  - generic ogrenci sinifindan bir instance aldik. Sinifin instance olustururken generic olan tipleri verdik.
    - o.TProp -> int oldu
    - o.KProp -> string oldu
    - o.MProp -> byte oldu

:warning: Arastirma odev; Generic bir sinif yazip bu sinigi kendi kolleksiyonunuz haline donusturun, Kendi generic kolleksiyonunuzu yaziniz. arkada list generic kolleksiyonu kullanin (Indexer nedir? Yield Nedir? Yield return nedir?)
Yield: bir sinifin icierisinde foreach ile gezebilme yetenegidir.
