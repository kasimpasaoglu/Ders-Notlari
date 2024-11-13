# SQL FUNCTIONS

- Function'lar, procedure'lere benzer ancak iki temel fark var
- 1. Func'lar geriye bir deger donebilir.
- 2. Func'lar selec sorgulari icerisinde kullanilabilir

- Ornek;
- Personellerin maaslarina %30 zam yapan bir Func yazalim

```SQL
CREATE FUNCTION Fn_ZamYap(@maas money)
RETURNS money
AS
BEGIN
    DECLARE @newMaas money
    SET @newMaas = @maas*1.30
    RETURN @newMaas
END

SELECT dbo.Fn_ZamYap(10) -- sabit bir deger girip calistirdik
SELECT Ad, Soyad, Maas, dbo.Fn_ZamYap(Maas) AS 'Yeni Maas'
FROM Personel   -- Sorgu icinde calistirilir
```

- Personelin Dogum Tarihini alip geriye yasini donduren Func yaziniz

```SQL
CREATE FUNCTION Fn_YasHesapla(@birth DATETIME)
RETURNS INT
AS
BEGIN
    RETURN DATEDIFF(YEAR, @birth, GETDATE())
END


SELECT Ad, Soyad, Maas, dbo.Fn_YasHesapla(DogumTarihi) AS 'YAS'
FROM Personel
```

- Categori Adi alip o kategoride kac adet urun oldugunu soyleyen bir func yaziniz

```SQL
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


SELECT dbo.Fn_CategoryCount('Electronics')
```

- :bulb: Functionlardan geriye bir tablo dondurebilirsiniz
  - Belirli bir harf ile baslayan urunleri getiren bir function yazalim

```SQL

CREATE FUNCTION Fn_GetProductByFirstChar(@startsWith NVARCHAR(1))
RETURNS TABLE
AS
    RETURN
    SELECT *
    FROM Product
    WHERE product_name LIKE @startsWith+'%'
```

- Artik fonksiyon bir tablo donecegi icin su sekilde cagrilir;

```SQL

SELECT * FROM dbo.Fn_GetProductByFirstChar('S') 

SELECT * FROM dbo.Fn_GetProductByFirstChar('S') WHERE product_name LIKE '%m%'

SELECT * FROM dbo.Fn_GetProductByFirstChar('S') WHERE price > 100
```
