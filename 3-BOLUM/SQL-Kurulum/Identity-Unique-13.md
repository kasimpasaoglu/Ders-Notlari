# `IDENTITY` & `UNIQUE` Keywords

Veri tabanlinda bir tabloya veri girisi yapilirken ID degerinin her zaman artan bir deger olmasi istenir.

- ID degeri developer ve ya kullanici tarafindan girilirse ID degerinde sorun olabilir.
- ID degerini sql'in otomatik olarak atamasini saglayabiliriz.

```SQL
CREATE TABLE Departman
(
 Id int IDENTITY(1,1), -- Id degeri 1 den baslayacak ve 1'er 1'er artacak
 Ad NVARCHAR(40) UNIQUE -- Ad alnina benzersiz deger girilmesi icin `UNIQUE` constraint'i ekledik.
)
```

- Artik veri girisi yaparken id yazmamiza gerek yok

```SQL
INSERT INTO Departman(Ad) Values
('Satis'),
('IK'),
('Pazarlama')
```
