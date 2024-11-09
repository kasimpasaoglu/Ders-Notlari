# Table Of Contents

- [Tablo olusturma](#tablo-olusturma)
  - [Tabloya veri girme islemleri](#tabloya-veri-girme-islemleri)
  - [Ekledigimiz verilere bakma](#ekledigimiz-verilere-bakma)
  - [Olusturdugumuz tabloyu silmek](#olusturdugumuz-tabloyu-silmek)
  - [Olsturmus oldugumuz database'i silmek](#olsturmus-oldugumuz-databasei-silmek)
  - [Where komutu](#where-komutu)
  - [Tablodan veri silmek](#tablodan-veri-silmek)
  - [Tablodaki bir veriyi guncellemek](#tablodaki-bir-veriyi-guncellemek)
  - [Tabloya yeni bir kolon ekleme](#tabloya-yeni-bir-kolon-ekleme)
    - [`UPDATE` vs `SELECT` Farkli](#update-vs-select-farkli)

---

# Tablo olusturma

- Personel tablosu olusturalim.
`create database FirstDatabase`
- Kullanilacak database secimi
`use FirstDatabase`
- Tablo olusturma

```SQL
create table Personel(
    Id int,
    Ad nvarchar(20),
    Soyad nvarchar(20),
    TC nvarchar(11),
    Eposta nvarchar(30),
    DATETIME DogumTarihi
)
```

## Tabloya veri girme islemleri

```SQL
insert into Personel(Id,Ad,Soyad,TC,Eposta) values(1,'Kerem', 'Ayaz', '12345678901', 'test@kerem.com')
insert into Personel(Id,Ad,Soyad,TC,Eposta) values(1,'Selcuk', 'Dinc','10987654321', 'test@selcuk.com')
```

## Ekledigimiz verilere bakma

```SQL
select Id,Ad,Soyad,TC,Eposta from Personel

-- sadece add ve eposta kolonlarini alalim
select Ad,Eposta from Personel
```

:bulb: Bir veri yiginini sorgulamak icin select keywordu kullanilir, from keywordu verilerin hangi tablodan getirilecegini belirler.

## Olusturdugumuz tabloyu silmek

```SQL
DROP TABLE Personel
```

## Olsturmus oldugumuz database'i silmek

```SQL
DROP DATABASE FirstDatabase
```

## Where komutu

Bir sorguya kosul ekler
 ornek; 1 id numarali personeli getirelim

```SQL
SELECT Id, Ad 
FROM Personel
WHERE Id=1
```

ornek; adi Kerem olan personeller gelsin

```SQL
SELECT Id, Ad
FROM Personel
WHERE Ad = 'Selcuk'
```

ornek; adi Kerem **ve ya** posta adresi '<test@selcuk.com>' olan gelsin

```SQL
SELECT Id, Eposta
FROM Personel
where Ad='Kerem' or Eposta='test@selcuk.com'
```

:bulb: C# ta gordugumuz **&&(ve)** **||(ve ya)** operatorleri yerine SQL'de **and** ve **or** kullaniyoruz.

- Personel tablomuza daha fazla veri girelim

```SQL
INSERT INTO Personel (Id, Ad, Soyad, Eposta)
VALUES
    (1, 'Ali', 'Yılmaz', 'ali.yilmaz@test.com'),
    (2, 'Ayşe', 'Kaya', 'ayse.kaya@test.com'),
    (3, 'Faruk', 'Uygur', 'test@faruk.com'),
    (4, 'Mehmet', 'Demir', 'mehmet.demir@test.com'),
    (5, 'Zeynep', 'Çelik', 'zeynep.celik@test.com'),
    (6, 'Ahmet', 'Şahin', 'ahmet.sahin@test.com'),
    (7, 'Fatma', 'Arslan', 'fatma.arslan@test.com'),
    (8, 'Burak', 'Koç', 'burak.koc@test.com'),
    (9, 'Elif', 'Güneş', 'elif.gunes@test.com'),
    (10, 'Can', 'Bozkurt', 'can.bozkurt@test.com'),
    (11, 'Serkan', 'Yıldırım', 'serkan.yildirim@test.com'),
    (12, 'Gül', 'Erdoğan', 'gul.erdogan@test.com'),
    (13, 'Tuba', 'Kurt', 'tuba.kurt@test.com'),
    (14, 'Emre', 'Çetin', 'emre.cetin@test.com'),
    (15, 'Büşra', 'Polat', 'busra.polat@test.com'),
    (16, 'Halil', 'Öztürk', 'halil.ozturk@test.com'),
    (17, 'Melis', 'Aksoy', 'melis.aksoy@test.com'),
    (18, 'Uğur', 'Kılıç', 'ugur.kilic@test.com'),
    (19, 'Cem', 'Eren', 'cem.eren@test.com'),
    (20, 'Hülya', 'Kara', 'hulya.kara@test.com');
```

## Tablodan veri silmek

```SQL
DELETE FROM Personel WHERE Id=20

DELETE FROM Personel WHERE Ad='Cem'
```

## Tablodaki bir veriyi guncellemek

- Id degeri 6 olan personelin Eposta alanini guncelleyelim

```SQL
UPDATE Personel SET Eposta='yenieposta@ahmet.com' WHERE Id=6
-- birden fazla degeri degistirmek icin virgul ile ayrilabilir
UPDATE Personel SET Ad='Kemal', Eposta='kemal@test.com' WHERE Ad='Ahmet'
```

- Listedeki herkesin e-posta alanlarinin basina birer a harfi ekleyelim;

```SQL
UPDATE Personel SET Eposta='a'+Eposta
```

:bulb: `update` islemini herhangi bir `where` sarti koymadigimiz icin butun listeye uygulamis olduk.
:bulb: '+' operatoru C#'ta oldugu gibi MsSql'de de birlestirme islemi yapar. Yukarida Eposta kolonu ile 'a' harfi birlestirilip tekrar eposta kolonu guncellendi.

## Tabloya yeni bir kolon ekleme

```SQL
ALTER TABLE Personel ADD Maas int
```

### `UPDATE` vs `SELECT` Farkli

- Ornek; Id = 5 olan personelin maasini %30 arttiralim

```SQL
UPDATE Personel SET Maas = Maas*1.30 WHERE Id=5
```

- Adi Zeynep olan personelin maasini %20 azaltalim

```SQL
UPDATE Personel SET Maas = Maas*0.8 WHERE Ad='Zeynep'
```

:bulb: Update yaptigimizda direk tablo etkilenir. +,*,- operatorlerini select sorgusu icinde de yapabiliriz.

ornek; tum personellerin maasini %50 arttiralim

```SQL
SELECT Ad, Maas*1.50 FROM Personel
```

:warning: Update yapilmadigi icin veriler etkilenmedi. Select sorgusu oldugu icin maaslari %50 zam ile getirdi. Yani getirilirken hesaplamayi yapti, tablonun kendisi etkilenmedi

- ornek; '+' operatorunu iki metinsel arasinda kullanilabilir

```SQL
SELECT Ad+Eposta FROM Personel
```

- ornek; eposta kolonunu <Ad@Soyad.com> olacak sekilde yapalim

```SQL
UPDATE Personel Set Eposta='@test.com'

UPDATE Personel Set Eposta=Ad+'@'+Soyad+'.com'
```
