
-- create database FirstDatabase

use FirstDatabase

-- CREATE TABLE Personel
-- (
-- 	Id int,
-- 	Ad nvarchar(20),
-- 	Soyad nvarchar(20),
-- 	TC nvarchar(11),
-- 	Eposta nvarchar(30)
-- )

insert into Personel
	(Id,Ad,Soyad,TC,Eposta)
values(1, 'Kerem', 'Ayaz', '12345678901', 'test@kerem.com')

insert into Personel
	(Id,Ad,Soyad,TC,Eposta)
values(2, 'Selcuk', 'Dinc', '10987654321', 'test@selcuk.com')

select Id, Ad, Soyad, TC, Eposta, Maas
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


INSERT INTO Personel
	(Id, Ad, Soyad, Eposta)
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


DELETE FROM Personel WHERE Id=20

DELETE FROM Personel WHERE Ad='Cem'

UPDATE Personel SET Eposta='yenieposta@ahmet.com' WHERE Id=6

UPDATE Personel SET Ad='Kemal', Eposta='kemal@test.com' WHERE Ad='Ahmet'

UPDATE Personel SET Eposta='a'+Eposta

ALTER TABLE Personel ADD Maas int

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

SELECT * FROM Personel WHERE Id != 5

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