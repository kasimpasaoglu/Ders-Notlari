# Generic Giris

- Generic C# 2.0 ile birlikte gelen bir ozelliktir.
- Genericten once tum kolleksiyonlarda, boxing ve unboxing yapilmasi gerekliydi. Cunku .net icerisinde generic gelene kadar tum kolleksiyonlar object tipinde calismaktaydi.
- Generic, kolleksiyonlarda, siniflarda ve metodlarda kullanilir.
- Tanim: Bir kolleksiyonu, sinifi ve ya metodu derleme asamasinda girmis oldugunuz tipe gore calistirabileceginiz bir ozelliktir.

## Generic Kolleksiyonlar

- Generic kolleksiyonlar normal kolleksiyonlardan (ArrayList vb.) farklidir.
- En populeri `list` kolleksiyonudur

### `List` Kolleksiyonu

syntax

```C#
List<int> degisken = new List<int>();
degisken.Add(1);
degisken.Add(10);
```

> int tipinde list generic bir kolleksiyon olusturduk

```C#
List<Ogrenci> ogrenciKolleksiyon = new List<Ogrenci>();

ogrenciKolleksiyon.Add(new Ogrenci(){Id=10, Name="Ali"});
```

> Kendi classlarimizi da verebiliyoruz
