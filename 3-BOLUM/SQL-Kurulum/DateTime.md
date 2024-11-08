# DateTime Sorgulari

- [`GETDATE()`](#getdate)
- [`DATEDIFF()`](#datediff)
- [`DATEADD()`](#dateadd)
- [`DATEPART()`](#datepart)

---

## `GETDATE()`

Su anki tarihi verir

```SQL
SELECT GETDATE() as 'Time & Date'
```

## `DATEDIFF()`

- SQL'de o anki tarih ve zaman bilgisini ekrana yazdirmak icin `SELECT GETDATE()` kullanilir
- Iki tarih arasindaki farki dondurur. 3 Parametre alir

1. Parametre (farkin cinsi, ay yil gun gibi)
2. Parametre Tarih alani
3. parametre tarig alani
:bulb: Tarih alanlari manuel girilebildigi gibi bir sogrudandan gelen kolonuda parametre olarak kullanabilirsiniz

- Id degeri 5 olan personelin yasi nedir?

```SQL
SELECT *, DATEDIFF(YEAR, DogumTarihi, GETDATE()) as 'Yas' FROM Personel WHERE Id=5
```

- DATEDIFF metodunda ilk parametre YEAR, MONTH, DAY HOUR gibi parametreler alabilir. Aldigi parametre cinsinden sonuc verir

## `DATEADD()`

Bir tahir uzerinde belirlirli bir sure ekleme islemini yapar

1. parametre eklenecek surenin cinsi(year,day gibi)
2. parametre eklenecek sure
3. hangi tarihe eklenecek

```SQL
-- bu gunun tarihine 18 yil ekleme
SELECT DATEADD(YEAR,18,GETDATE())
```

## `DATEPART()`

Bir tarihin sadece belirli bir bolumunu almamizi saglar

```SQL
-- dogumtarihi kolonundan sadece yil bilgisini getir
SELECT DATEPART(YEAR, DogumTarihi) From Personel
```
