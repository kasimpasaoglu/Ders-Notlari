# Table Of Contents

- [`ORDER BY []`](#order-by-)
- [`TOP` Keyword](#top-keyword)
- [`LEN()`](#len)
- [`SUBSTRING()`](#substring)
- [`REPLICATE()`](#replicate)
- [`LIKE` Keyword](#like-keyword)
  - [(ARA BILGI) Kolonlara Gecici Isimler Vermek `AS`](#ara-bilgi-kolonlara-gecici-isimler-vermek-as)

---

## `ORDER BY []`

- Ad kolonuna gore siralayalim

```SQL
SELECT * FROM Personel ORDER BY Ad
```

- Sonuna DESC eklenerek tersten Siralanabilir

```SQL
SELECT * FROM Personel ORDER BY Id DESC
```

ORNEK ODEV;

- Id degeri 5 degerine esit olmayan personelleri listeleyelim
- 6 numarali personelin maasina %50 zam yapalim
- id degeri 2,6,9 olan personllerin id ve eposta alanlarini ekrana getirelim

```SQL
SELECT * FROM Personel WHERE Id != 5
-- != yerine <> kullanildi ???
UPDATE Personel Set Maas=Maas*1.50 WHERE Id=6

SELECT * FROM Personel WHERE Id=2 or Id=6 or Id=9
```

> Birden fazla filtre eklenecekse `or` yerine `in` keywordu kullanilabilir

```SQL
SELECT * FROM Personel WHERE Id in (2,6,9)
-- id 2,6,9 olanlar
```

```SQL
SELECT * FROM Personel WHERE Id not in (2,6,9)
-- id 2,6,9 olmayanlar
```

```SQL
SELECT * FROM Personel WHERE Id <> 5
```

## `TOP` Keyword

Cok satirli bir sonuc icerisinden istediginiz kadarini almamimzi saglar

```SQL
SELECT TOP 2 Id,Ad,Soyad FROM Personel WHERE Maas=10000
```

> `TOP` keywordunden sonra kac tane sonuc istedigimizi girmemiz gerekir

En cok maas alan personelin adi nedir? => `SELECT TOP 1 * FROM Personel ORDER BY Maas DESC`

## `LEN()`

- Metinsel degerlerin uzunlugunu verir

```SQL
SELECT Ad,LEN(Ad) FROM Personel
```

- Personel listesindeki en uzun isimli personelin bilgilerini yazdiralim

```SQL
-- Isim uzunluklarina gore siraladik hepsini yazdirdik
SELECT * FROM Personel ORDER BY LEN(Ad) DESC

-- TOP 1 ekleyerek sadece en ustteki(adi en uzun olan veriyi aldik)
SELECT TOP 1 * FROM Personel ORDER BY LEN(Ad) DESC
```

## `SUBSTRING()`

- Metnin belli bir parcasini almak icin kullanilir
Ornek; Ad kolonundakilerin sadece bas harflerini alalim
:warning: index 0 dan degil 1 den baslar

>Ilk harfi alalim

```SQL
SELECT Ad, SUBSTRING(Ad,1,1) FROM PERSONEL
```

>Son harfi alalim

```SQL
SELECT Ad, SUBSTRING(Ad, LEN(Ad), 1) FROM Personel
```

> Bas harfi ve son harfi alip ortasini ** ile dolduralim

```SQL
SELECT Ad, SUBSTRING(Ad,1,1)+'****'+SUBSTRING(Ad,LEN(Ad),1) FROM Personel
```

## `REPLICATE()`

>Yildizlari personelin adi kadar yapalim

```SQL
SELECT Ad, SUBSTRING(Ad,1,1)+REPLICATE('*', LEN(Ad)-2)+SUBSTRING(Ad,LEN(Ad),1) FROM Personel
```

- Replicate belirli bir karakteri, belirlenen adet kadar olusturmak icin kullanilir. (Ornekte: '*' karakterini Len(Ad)'in -2 si kadar bastik)

## `LIKE` Keyword

- `WHERE` ile kolon bazli bir kosul ekleme islemi yapiyorduk
- `LIKE` komutu ise kolon bazli degilde hucre bazli bir arama yapmaya yarar.

```SQL
-- Adi 'M' Harfi ile baslayan Personelleri getirir
SELECT * FROM Personel WHERE Ad LIKE 'M%'

-- Adi 'K' Harfi ile biten personelleri getir
SELECT * FROM Personel WHERE Ad Like '%k'

-- Ad alaninin icinde 'a' gecen personeller
SELECT * FROM Personel WHERE Ad Like '%a%'
```

:Bulb: Buyuk kucuk harf farketmez.

Diger Kullanim Ornekleri;

```SQL
-- adi b ve ya m ile baslayan personeller
SELECT * FROM Personel WHERE Ad LIKE '[BM]%'

-- adi n ya da k ile bitenler
SELECT * FROM Personel WHERE Ad LIKE '%[NK]'

-- adinin bas harfi a-e arasinda olanlar
SELECT * FROM Personel WHERE Ad LIKE '[A-E]%'

-- adinin bas harfi a-e arasinda olmayanlar
SELECT * FROM Personel WHERE Ad LIKE '[^A-E]%'

-- adinin 3. karakteri L olanlar
SELECT * FROM Personel WHERE Ad LIKE '__L%'

-- 2.harfi e ve 5. harf e olanlar
SELECT * FROM Personel WHERE Ad LIKE '_e__e%'
```

`LIKE` keywordune `NOT` oneki eklendigi zaman sorgu tam tersine cevrilebilir

```SQL

-- adinin bas harfi a-e arasinda olmayanlar
SELECT * FROM Personel WHERE Ad LIKE '[^A-E]%'

-- Ayni islemi NOT ile yapabiliriz
SELECT * FROM Personel WHERE Ad NOT LIKE '[A-E]%'
```

### (ARA BILGI) Kolonlara Gecici Isimler Vermek `AS`

- Aggragete Function yazdigimizda;

```SQL
SELECT COUNT(Ad) as 'Personel Sayisi' FROM Personel
```

> Personel sayisi, toplam maas ve ortalama maasi ekrana yazdirlarim

```SQL
SELECT COUNT(Ad) as 'Personel Sayisi', SUM(Maas) as 'Toplam Maas', AVG(Maas) as 'Ortalama Maas' FROM Personel
```
