
# Table Of Contents

- [Kurulum](#kurulum)
  - [DateBase Nedir](#datebase-nedir)
  - [Yeni DataBase Olusturma](#yeni-database-olusturma)
    - [Tablo olusturma](#tablo-olusturma)
    - [WHERE komutu](#where-komutu)
    - [SQL Server Matematik Fonksiyonlari](#sql-server-matematik-fonksiyonlari)
      - [`COUNT()`](#count)
      - [`SUM()`](#sum)
      - [`MAX()` & `MIN()` & `AVG()`](#max--min--avg)
    - [`ORDER BY [kolon]`](#order-by-kolon)
    - [`TOP` Keyword](#top-keyword)
    - [`LEN()`](#len)
    - [`SUBSTRING()`](#substring)
    - [`REPLICATE()`](#replicate)

---

# Kurulum

>Docker icin kurulum;
>`docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong!Passw0rd" -p 1433:1433 --name mssql_container -d mcr.microsoft.com/mssql/server:2022-latest`\
>Açıklama:
>
>- ACCEPT_EULA=Y: Microsoft’un kullanım şartlarını kabul ediyorsun.
>- SA_PASSWORD=YourStrong!Passw0rd: sa kullanıcısı için güçlü bir şifre belirlemen gerekli (şifre en az 8 karakter, büyük/küçük harf, rakam ve özel karakter içermeli).
>- -p 1433:1433: Konteynerin 1433 portunu ana makinenin 1433 portuna yönlendirir.
>- --name mssql_container: Konteynere bir isim verir (istediğin ismi kullanabilirsin).
>- -d: Konteyneri arka planda çalıştırır.

SQL server iki parcadan olusur

1. SQL Server Engine => Motor; tum veri tabani islemlerini yurutmekten sorumludur
2. SQL Server Management Studio  => SQL SMS; Motorla developeri haberlestirmek icin vardir. Bir editordur.

## DateBase Nedir

Onceki calismalarimza verileri hep bir degiskenlere atadir. Ancak burdaki veriler hep geciciydi. (RAM de tutuluyordu)
Ancak gercek hayatta uygulama kapansa bile verilerin kaybolmayacagi bir yere ihtiyac vardir. (Diske Yazma)\
Verileri bir txt dosyasinda bile yazabiliriz, bu da bir cesit veri tabaninir.
Ancak daha iliskisel(veriler arasinda iliskileri olan) ve buyuk verileri tutmak istedgimizde bunlari artik bir txt olarak tutamayiz. Ornegin Excel kullaniriz.\
Excel tarz islevleri yerine getirebiliyor olsada kullanim amaci olarak bu is icin yeterli degildir.
Burda ihtiyacimiz olan sey bir **veritabanidir** (DataBase)

Iliskisel veri tabani icin Turkiyede en cok kullanilan 3 adet database vardir

- MSSql => Microsoft
- MySql =>
- Oracle => Oracle

**SQL Nedir**: VeriTabani sorgulama dilidir.

**Neler yapacagiz?** MsSql ile calismalarimiz iki asamada gerceklesecek;

1. MsSql uzerinde veri tabanini SQL Dili ile sorgulayacagiz
2. C# ile MsSql server'i konusturacagiz.

>Farkli bir veri tutma yapisi olan NoSql veritabanlari da vardir.
Bunlar ozellestirilmis veri tabanlaridir. Mesela sadece bir veri tipi ile calisir.

Server name kismina 3 sey yazilabilir,
bilgisayarin ismi, localhost ve ya '.' konabilir.

Veri tabani kurarken;

1. DataBase olusturulur

2. Database icinde tablolar olusturulur. Birden fazla tablo olusabilir.
    - Bir tabloda personel bilgileri tutarken digerinde urunleri tutabiliriz
    - Tablolar satir ve kolonlardan(sutun) olusur.
    - kolonlar adlandirilir ve sonra satirlar olusturulup veri yazilir.

## Yeni DataBase Olusturma

Sol taraftaki Object Explorer'da DataBases e sag tiklayip new Database diyerek yeni acabiliyoruz.

Ancak biz kodlama ile database olusturacagiz.

```SQL
-- ilk kodumuzu yazalim.
create database FirstDatabase
```

Hali hazirda bir database var ise o database e gecis yapmak icin

```SQL
use FirstDatabase
```

veri tabaninda bir veriyi gostermek icin kullanacagimiz komut `Select`'tir

ilk select komutunu calistiralim.

```SQL
select 1
```

SQL Server'da kullanabilecegimiz bazi veri tipleri vardir.
Bu tiplerden bazilari;

1. int => sayisal deger tutmak icin
2. nvarchar => metinsel veri tutmak icin vardir. (string)
    - tanimlanirken uzunluk verilmesi gereklidir. bunun icin `nvarchar(10)`(10 karakter) ve ya `nvarchar(max)`(max tutabilecegi kadar).
:bulb: Ilk tabloyu olusturmak icin simdilik bu veri tipleri ile calismaya baslayacagiz.

### Tablo olusturma

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
    Eposta nvarchar(30)
)
```

- Tabloya veri girme islemleri

```SQL
insert into Personel(Id,Ad,Soyad,TC,Eposta) values(1,'Kerem', 'Ayaz', '12345678901', 'test@kerem.com')
insert into Personel(Id,Ad,Soyad,TC,Eposta) values(1,'Selcuk', 'Dinc','10987654321', 'test@selcuk.com')
```

- Ekledigimiz verilere bakma

```SQL
select Id,Ad,Soyad,TC,Eposta from Personel

-- sadece add ve eposta kolonlarini alalim
select Ad,Eposta from Personel
```

:bulb: Bir veri yiginini sorgulamak icin select keywordu kullanilir, from keywordu verilerin hangi tablodan getirilecegini belirler.

- Olusturdugumuz tabloyu silmek icin;

```SQL
DROP TABLE Personel
```

- Olsturmus oldugumuz database'i silmek icin

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

ornek; adi Kerem **ve ya** posta adresi <test@selcuk.com> olan gelsin

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

- Tablodan veri silmek;

```SQL
DELETE FROM Personel WHERE Id=20

DELETE FROM Personel WHERE Ad='Cem'
```

- Tablodaki bir veriyi guncellemek;

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

:bulb: update islemini herhangi bir where sarti koymadigimiz icin butun listeye uygulamis olduk.
:bulb: '+' operatoru C#'ta oldugu gibi MsSql'de de birlestirme islemi yapar. Yukarida Eposta kolonu ile 'a' harfi birlestirilip tekrar eposta kolonu guncellendi.

- Tabloya yeni bir kolon ekleme;

```SQL
ALTER TABLE Personel ADD Maas int
```

- Id = 5 olan personelin maasini %30 arttiralim

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

Update yapilmadigi icin veriler etkilenmedi. Select sorgusu oldugu icin maaslari %50 zam ile getirdi. Yani getirilirken hesaplamayi yapti, tablonun kendisi etkilenmedi

ornek; '+' operatorunu iki metinsel arasinda kullanilabilir

```SQL
SELECT Ad+Eposta FROM Personel
```

ornek; eposta kolonunu <Ad@Soyad.com> olacak sekilde yapalim

```SQL
UPDATE Personel Set Eposta='@test.com'

UPDATE Personel Set Eposta=Ad+'@'+Soyad+'.com'
```

## SQL Server Matematik Fonksiyonlari

### `COUNT()`

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

### `SUM()`

Parametre olarak aldigi kolan icerisindeki verileri toplar

```SQL
SELECT SUM(MAAS) from Personel where Id=1 or Id=5
```

> 1 ve 5 numarali iddeki maas bilgilerini toplar

```SQL
SELECT SUM(MAAS) from Personel where Id>=1 and Id<=5
```

> Id 1 den 5 e kadar olan personellerin maaslarini toplar

### `MAX()` & `MIN()` & `AVG()`

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

## `ORDER BY [kolon]`

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

>!= yerine <> kullanilmalidir

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

### (ARA BILGI) Kolonlara Gecici Isimler Vermek

- Aggragete Function yazdigimizda;

```SQL
SELECT COUNT(Ad) as 'Personel Sayisi' FROM Personel
```

> Personel sayisi, toplam maas ve ortalama maasi ekrana yazdirlarim

```SQL
SELECT COUNT(Ad) as 'Personel Sayisi', SUM(Maas) as 'Toplam Maas', AVG(Maas) as 'Ortalama Maas' FROM Personel
```

## DateTime Sorgulari

### `GETDATE()`

Su anki tarihi verir

```SQL
SELECT GETDATE() as 'Time & Date'
```

### `DATEDIFF()`

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

### `DATEADD()`

Bir tahir uzerinde belirlirli bir sure ekleme islemini yapar

1. parametre eklenecek surenin cinsi(year,day gibi)
2. parametre eklenecek sure
3. hangi tarihe eklenecek

```SQL
-- bu gunun tarihine 18 yil ekleme
SELECT DATEADD(YEAR,18,GETDATE())
```

### `DATEPART()`

Bir tarihin sadece belirli bir bolumunu almamizi saglar

```SQL
-- dogumtarihi kolonundan sadece yil bilgisini getir
SELECT DATEPART(YEAR, DogumTarihi) From Personel
```
