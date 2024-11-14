-- PRIMATY KEY ve FOREING KEY Constraintler

-- Mevcut tabloya Primary Key Eklemek

ALTER TABLE Category
ADD CONSTRAINT PK_CategoryId PRIMARY KEY(category_id)
-- Bir tablonun id kolonunun primary key olmasi, o tabloda id alaninda benzersizlik saglar. Ayrica her kaydin Primary Key degerinden ayirt edilmesini saglar
-- Id alani primary key olmasi sayesinde, veri aramalarinda id degeri uzerinden arama yapilmasi yuk hiz ve verimlilik saglar

-- Foreing Key Constraint 
-- Bir Primary Key ile birlikte calisir. Iliskisel tablolarda, her iki tabloyu fiziki olarak birbirine baglamak icin, primary key ve foreign key constraint kullanilir.
-- Product tablosundaki category_id alani ile Category tablosundaki category_id alanini birbirine bagliyoruz,
-- Category tablosundaki category_id alani Primary Key
-- Product tablosundaki category_id alanini Foreign Key yapalim

ALTER TABLE Product
ADD CONSTRAINT FK_Product_Category FOREIGN KEY (category_id)
REFERENCES Category(category_id)
ON DELETE CASCADE

-- ON DELETE CASCADE; Bir kategori silindiginde o kategoriye bagli olan tum urunleri sil!

INSERT INTO Product
    (product_id, product_name, price, stock, category_id)
VALUES
    (201, 'Tabak', 10, 10, 6)
-- Olmayan kategoride urun eklemeyi kabul etmedi,
-- Ayrica categori tablosundan herhangi bir kategori silinirse product tablosunda o categoriye iliskili olan butun urunleri silecektir!

-- ON DELETE SET NULL; Bu komutu girersek, Category silindigi zaman productlarin category_id kolonuna NULL degeri atar.
-- ON DELETE RESTRICT; Category silindindiginde, ona bagli olan productlar var ise, silinmesini engeller.
-- ON DELETE NO ACTION; Bu kural da, yukaridaki gibi isler.

-- Constraintler: kolonlara belirli kistlar getirmek amaci ile kolon bazli ayarlama yapilaridir.

-- Ornek; Primary Key bir Constraint'dir

-- Unique Constraint : Bir kolonu unique olarak belirlerseniz o kolonda bir veri tekrar edemez.
-- Constraintler tablo olusturulurken verilebilecegi gibi sonradan da eklenebilir;

ALTER TABLE Product
ADD CONSTRAINT Uq_Name UNIQUE (product_name)

-- Eger unique yapmak istenilen kolonda ayni degerler varsa hata verir

-- CHECK CONSTRAINT 
-- Kolona girilecek olan veririnin belirli sartlar saglamasi kuralini koyabilecegimiz bir constraint'dir.

-- ornek; price alani sifirdan kucuk olamaz yapalim

ALTER TABLE Product
ADD CONSTRAINT CHK_Price CHECK (price > 0)

-- DEFAULT CONSTRAINT
-- Uygulandigi kolona veri girilmedigi durumda, hangi verinin girilecegini belirler.
-- Yani veri girisi yapildiginda bir kolona veri girilmezse o kolon NULL olmak yerine default olarak belirleyecegimiz degeri alsin.

ALTER TABLE Product
ADD InsertedDate DATETIME DEFAULT(GETDATE())

--NOT NULL CONSTRAINT
-- Verilen kolonun icinde NULL olmasini engellemek icin kullanilir.

ALTER TABLE Product
ADD Tarih DATETIME DEFAULT(GETDATE()) NOT NULL

SELECT *
FROM Product

-- TRIGGER
-- Tetikleyicilerdir. Bir olay oldugunda (insert, update, delete gibi) baska olaylari tetiklemeyi TRIGGER ile yapabiliriz.
-- Ornegin; Product tablosuna bir insert geldigi anda hesap isimli tabloya price ve stok degeri carpilip eklensin.

-- Oncelikle hesap tablosunu olusturalim

CREATE TABLE Hesap
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Total MONEY
)

-- TRIGGER Yazalim; product tablosuna insert geldiginde
GO
CREATE TRIGGER TRG_AfterInsertProduct
ON Product
AFTER INSERT
AS
BEGIN
    DECLARE @stok INT
    DECLARE @price MONEY

    -- Product tablosuna insert edilen veriyi bir satir olarak almam lazim `inserted` keywordunu kullanacagiz

    SELECT @stok = stock, @price = price from inserted
    -- yeni gelen veri girisindeki degerleri aldik, simdi bunlari yeni olusturdugumuz tabloya insert edecegiz

    INSERT INTO Hesap (Total) VALUES (@stok * @price)
END
GO

-- artik bu tabloya bir veri girisi oldugunda (insert) yeni eklenen verideki stok ve fiyat bilgisini carpip, hesap tablosunda yeni bir satir ekleyip orayi ekleyecek

INSERT INTO Product (product_id, product_name, price, stock, category_id)
VALUES (202,'Bicak', 10,50,4)

SELECT * FROM Hesap