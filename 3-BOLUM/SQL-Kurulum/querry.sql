
create database FirstDatabase

use FirstDatabase

-- CREATE TABLE Personel
-- (
-- 	Id int,
-- 	Ad nvarchar(20),
-- 	Soyad nvarchar(20),
-- 	TC nvarchar(11),
-- 	Eposta nvarchar(30),
-- 	Maas int,
-- 	DogumTarihi DATETIME
-- )

insert into Personel
	(Id,Ad,Soyad,TC,Eposta)
values(1, 'Kerem', 'Ayaz', '12345678901', 'test@kerem.com')

insert into Personel
	(Id,Ad,Soyad,TC,Eposta)
values(2, 'Selcuk', 'Dinc', '10987654321', 'test@selcuk.com')

select Id, Ad, Soyad, TC, Eposta
from Personel

select Ad, Eposta
from Personel

-- DROP TABLE Personel

-- DROP DATABASE FirstDatabase

SELECT Id, Ad, Eposta
FROM Personel
WHERE Id=1

SELECT Id, Ad
FROM Personel
WHERE Ad = 'Selcuk'

SELECT Id, Eposta
FROM Personel
where Ad='Kerem' or Eposta='test@selcuk.com'


INSERT INTO Personel (Id, Ad, Soyad, TC, Eposta, Maas, DogumTarihi) 
VALUES 
(1, 'Ali', 'Yılmaz', '12345678901', 'ali.yilmaz@test.com', 10500, '1992-01-05'),
(2, 'Ayse', 'Kaya', '22345678902', 'ayse.kaya@test.com', 9500, '1993-04-10'),
(3, 'Faruk', 'Uygur', '32345678903', 'faruk.uygur@test.com', 11000, '1989-07-15'),
(4, 'Mehmet', 'Demir', '42345678904', 'mehmet.demir@test.com', 10200, '1990-10-20'),
(5, 'Zeynep', 'Çelik', '52345678905', 'zeynep.celik@test.com', 9800, '1985-02-25'),
(6, 'Ahmet', 'Sahin', '62345678906', 'ahmet.sahin@test.com', 10000, '1988-06-30'),
(7, 'Fatma', 'Arslan', '72345678907', 'fatma.arslan@test.com', 12000, '1991-12-10'),
(8, 'Burak', 'Koç', '82345678908', 'burak.koc@test.com', 9000, '1995-05-18'),
(9, 'Elif', 'Güneş', '92345678909', 'elif.gunes@test.com', 9700, '1997-11-22'),
(10, 'Can', 'Bozkurt', '12345678910', 'can.bozkurt@test.com', 11500, '1980-08-12'),
(11, 'Serkan', 'Yıldırım', '22345678911', 'serkan.yildirim@test.com', 10500, '1992-09-25'),
(12, 'Gül', 'Erdogan', '32345678912', 'gul.erdogan@test.com', 10800, '1983-03-19'),
(13, 'Tuba', 'Kurt', '42345678913', 'tuba.kurt@test.com', 9200, '1996-02-15'),
(14, 'Emre', 'Çetin', '52345678914', 'emre.cetin@test.com', 9500, '1994-11-05'),
(15, 'Büşra', 'Polat', '62345678915', 'busra.polat@test.com', 10100, '1993-07-09'),
(16, 'Halil', 'Öztürk', '72345678916', 'halil.ozturk@test.com', 9800, '1991-06-28'),
(17, 'Melis', 'Aksoy', '82345678917', 'melis.aksoy@test.com', 11500, '1988-10-31'),
(18, 'Uğur', 'Kılıç', '92345678918', 'ugur.kilic@test.com', 9400, '1985-05-20'),
(19, 'Cem', 'Eren', '12345678919', 'cem.eren@test.com', 10000, '1990-01-01'),
(20, 'Hülya', 'Kara', '22345678920', 'hulya.kara@test.com', 10400, '1992-03-12');


DELETE FROM Personel WHERE Id=20

DELETE FROM Personel WHERE Ad='Cem'

UPDATE Personel SET Eposta='yenieposta@ahmet.com' WHERE Id=6

UPDATE Personel SET Ad='Kemal', Eposta='kemal@test.com' WHERE Ad='Ahmet'

UPDATE Personel SET Eposta='a'+Eposta

UPDATE Personel SET Maas=10000

UPDATE Personel SET Maas = Maas*1.30 WHERE Id=5

UPDATE Personel SET Maas = Maas*0.8 WHERE Ad='Zeynep'

SELECT Ad, Maas*1.50
FROM Personel

SELECT Ad+Eposta
FROM Personel

UPDATE Personel Set Eposta='@test.com'

UPDATE Personel Set Eposta=Ad+'@'+Soyad+'.com'

SELECT COUNT(Ad) FROM Personel

-- Iki tane ayni isimde personel yapalim

UPDATE Personel Set Ad='Ali' WHERE Ad='Faruk'

SELECT COUNT(Ad) FROM Personel WHERE Ad='Ali'

SELECT SUM(Maas) FROM Personel WHERE Id=1 OR Id=5

SELECT SUM(Maas) FROM Personel WHERE Id>=1 AND Id<=5

SELECT MAX(Maas) From Personel

SELECT MIN(Maas) From Personel

SELECT AVG(Maas) FROM Personel

SELECT SUM(Maas)/COUNT(Maas) FROM Personel

SELECT * FROM Personel ORDER BY Id DESC

SELECT * FROM Personel WHERE Id <> 5

UPDATE Personel Set Maas=Maas*1.50 WHERE Id=6

SELECT * FROM Personel WHERE Id=2 or Id=6 or Id=9

SELECT * FROM Personel WHERE Id IN(2,6,9)

SELECT * FROM Personel WHERE Id NOT IN(2,6,9)

SELECT TOP 2 Id,Ad,Soyad FROM Personel WHERE Maas=10000

SELECT TOP 1 * FROM Personel ORDER BY Maas DESC

-- inner querry (gelecek konu)
SELECT * FROM Personel WHERE Maas=(SELECT MAX(Maas) FROM Personel)

SELECT Ad,LEN(Ad) FROM Personel

SELECT * FROM Personel ORDER BY LEN(Ad) DESC

SELECT Ad, SUBSTRING(Ad,1,1) FROM PERSONEL

SELECT Ad, SUBSTRING(Ad, LEN(Ad), 1) FROM Personel

SELECT Ad, SUBSTRING(Ad,1,1)+REPLICATE('*', LEN(Ad)-2)+SUBSTRING(Ad,LEN(Ad),1) FROM Personel

SELECT * FROM Personel WHERE Ad='Selcuk'

SELECT * FROM Personel WHERE Ad LIKE 'm%'

SELECT * FROM Personel WHERE Ad Like '%k'

SELECT * FROM Personel WHERE Ad Like '%a%'

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

UPDATE Personel SET TC=12345678901 WHERE Id>0 and Id<10

SELECT * FROM Personel WHERE TC IS NULL

SELECT COUNT(Ad) as 'Personel Sayisi' FROM Personel

SELECT COUNT(Ad) as 'Personel Sayisi', SUM(Maas) as 'Toplam Maas', AVG(Maas) as 'Ortalama Maas' FROM Personel


-- Tarih ve Zaman Islemleri

-- SQL'de o anki tarih ve zaman bilgisini ekrana yazdirmak icin `SELECT GETDATE()` kullanilir

SELECT GETDATE() as 'Time & Date'

SELECT * FROM Personel

SELECT *, DATEDIFF(YEAR, DogumTarihi, GETDATE()) as 'Yas' FROM Personel WHERE Id=5

-- 35 yasindan buyuk personeller

SELECT *,DATEDIFF(YEAR, DogumTarihi, GETDATE()) as 'Yas' FROM Personel WHERE DATEDIFF(YEAR, DogumTarihi, GETDATE()) > 35

-- sirketin yas ortalamalasi

SELECT AVG(DATEDIFF(YEAR, DogumTarihi, GETDATE())) as 'Ortalama' FROM Personel

-- yaslarin toplami

SELECT SUM(DATEDIFF(YEAR, DogumTarihi, GETDATE())) as 'Toplam Yas' FROM Personel

-- bu gunun tarihine 18 yil ekleme
SELECT DATEADD(YEAR,18,GETDATE())

--emeklilik 60 yasinda ise personelin emekliligine ne kadar kaldigini yazalim

SELECT *, DATEADD(YEAR,60- DATEDIFF(YEAR, DogumTarihi, GETDATE()), GETDATE()) as 'Emeklilik Tarihi' FROM Personel

SELECT DATEPART(YEAR, DogumTarihi) From Personel

-- 30 - 40 yas arasindaki  personellerin ortalama yasi

SELECT AVG(DATEDIFF(YEAR,DogumTarihi, GETDATE())) FROM Personel WHERE DATEDIFF(YEAR,DogumTarihi, GETDATE()) > 30 and DATEDIFF(YEAR,DogumTarihi, GETDATE()) < 40
