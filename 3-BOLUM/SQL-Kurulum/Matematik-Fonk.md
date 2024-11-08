# Table Of Contents

- [SQL Server Matematik Fonksiyonlari](#sql-server-matematik-fonksiyonlari)
  - [`COUNT()`](#count)
  - [`SUM()`](#sum)
  - [`MAX()` & `MIN()` & `AVG()`](#max--min--avg)

---

# SQL Server Matematik Fonksiyonlari

## `COUNT()`

- Tablodaki kayit sayisini ogrenme;

```SQL
SELECT COUNT(Ad) FROM Personel
```

- Count fonksiyonuna where sarti ekleme
  - Ad alani Ali olan kac kisi var?

```SQL
SELECT COUNT(Ad) FROM Personel WHERE Ad='Ali'
```

> Count fonskiyonu icine yazdigimiz parametre bu ornek icin farketmiyor, soyadlari da sayabiliriz adlari da

## `SUM()`

Parametre olarak aldigi kolan icerisindeki verileri toplar

```SQL
SELECT SUM(MAAS) from Personel where Id=1 or Id=5
```

> 1 ve 5 numarali iddeki maas bilgilerini toplar

```SQL
SELECT SUM(MAAS) from Personel where Id>=1 and Id<=5
```

> Id 1 den 5 e kadar olan personellerin maaslarini toplar

## `MAX()` & `MIN()` & `AVG()`

- Verilen kolon icindeki en buyuk ve ya en kucuk degeri getirecektir.

```SQL
SELECT MAX(Maas) From Personel

SELECT MIN(Maas) From Personel

SELECT AVG(Maas) FROM Personel
```

>AVG olmadan ortalama bulalim

```SQL
SELECT SUM(Maas)/COUNT(Maas) FROM Personel
```

:bulb: Bu metodlar aggragete metodlardir ve tek baslarina kullanir. Yani en dusuk maasa sahip personelin ad ve ya soyad kolonunu dogrudan alamiyoruz.

:bulb: bir tablonun butun kolonlarini getirmek icin kolon adini yazmamiza gerek yoktur.

```SQL
SELECT * FROM Personel
```
