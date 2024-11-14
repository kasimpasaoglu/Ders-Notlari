# TRIGGER

- Tetikleyicilerdir. Bir olay oldugunda (insert, update, delete gibi) baska olaylari tetiklemeyi TRIGGER ile yapabiliriz.
- Ornegin; Product tablosuna bir insert geldigi anda hesap isimli tabloya price ve stok degeri carpilip eklensin.
- Oncelikle hesap tablosunu olusturalim

```SQL
CREATE TABLE Hesap
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Total MONEY
)
```

> TRIGGER Yazalim; product tablosuna insert geldiginde

```SQL
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
```

- Artik bu tabloya bir veri girisi oldugunda (insert) yeni eklenen verideki stok ve fiyat bilgisini carpip, hesap tablosunda yeni bir satir ekleyip orayi ekleyecek

>Deneyelim

```SQL
INSERT INTO Product (product_id, product_name, price, stock, category_id)
VALUES (202,'Bicak', 10,50,4)

SELECT * FROM Hesap
```
