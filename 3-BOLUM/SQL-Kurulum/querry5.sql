-- SQL Function
-- Ornek;
-- Personellerin maaslarina %30 zam yapan bir Func yazalim
GO
CREATE FUNCTION Fn_ZamYap(@maas money)
RETURNS money
AS
BEGIN
    DECLARE @newMaas money
    SET @newMaas = @maas*1.30
    RETURN @newMaas
END
GO


SELECT dbo.Fn_ZamYap(10)

-- Select sorgusu icin calistiralaim

SELECT Ad, Soyad, Maas, dbo.Fn_ZamYap(Maas) AS 'Yeni Maas'
FROM Personel

-- Personelin Dogum Tarihini alip geriye yasini donduren Func yaziniz
GO
CREATE FUNCTION Fn_YasHesapla(@birth DATETIME)
RETURNS INT
AS
BEGIN
    RETURN DATEDIFF(YEAR, @birth, GETDATE())
END
GO

SELECT Ad, Soyad, Maas, dbo.Fn_YasHesapla(DogumTarihi) AS 'YAS'
FROM Personel

-- Categori Adi alip o kategoride kac adet urun oldugunu soyleyen bir func yaziniz
GO
CREATE FUNCTION Fn_CategoryCount(@name nvarchar(MAX))
RETURNS INT
AS
BEGIN
    DECLARE @id INT
    SELECT @id = category_id
    from Category
    WHERE category_name = @name
    RETURN (SELECT SUM(stock)
    FROM Product
    WHERE category_id = @id )
END
GO

SELECT dbo.Fn_CategoryCount('Electronics')

-- Functionlardan geriye bir tablo dondurebilirsiniz

-- Belirli bir harf ile baslayan urunleri getiren bir function yazalim
GO
CREATE FUNCTION Fn_GetProductByFirstChar(@startsWith NVARCHAR(1))
RETURNS TABLE
AS
    RETURN
    SELECT *
    FROM Product
    WHERE product_name LIKE @startsWith+'%'
GO

-- Artik fonksiyon bir tablo donecegi icin su sekilde cagrilir;

SELECT * FROM dbo.Fn_GetProductByFirstChar('S') 

SELECT * FROM dbo.Fn_GetProductByFirstChar('S') WHERE product_name LIKE '%m%'

SELECT * FROM dbo.Fn_GetProductByFirstChar('S') WHERE price > 100

-- SCHEMA Kavrami

GO
CREATE SCHEMA csharp
GO

-- olusturdugumuz yeni semayi kullanan bir funcion yazalim
GO
CREATE FUNCTION csharp.Fn_StokTopla(@stok INT, @price MONEY)
RETURNS money
AS
BEGIN
DECLARE @toplam MONEY
SET @toplam = @stok*@price
RETURN @toplam
END
GO

SELECT product_name, stock, price, csharp.Fn_StokTopla(stock, price) AS 'Toplam Tutar' FROM Product


