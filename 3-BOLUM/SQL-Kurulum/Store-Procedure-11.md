# STORE PROCEDURE

- SQL'deki metodlardir.
- Belirli kod bloklarini store procedure olarak yazip daha sonra calistirabiliriz.
- Performansi kotu etkileyecek olan karmasik bir sorgu yapilacaksa kesinlikle Store Procedure yazilmasi tavsiye edilir. Cunku SQL bu sayede bu sorguyu yapabilmek icin gerekli ilk 3 adimi hafizaye onceden atmis olur. Geriye sadece sonuclari getirme kismi kalir

```SQL
CREATE PROCEDURE SP_First
AS
BEGIN
    SELECT *
    FROM Product
END
```

> `PROCEDURE` yerine `PROC` yazilabilir

- Begin/End C#'taki parantez ac ve parantez kapa gibidir.
- Bunu Stored Procedures klasorune kaydeder
- `EXECUTE` ve ya `EXEC` komutu ile bu SP cagrilabilir

```SQL
EXECUTE SP_First
```

- Yazilmis bir procedure'u alter komutu ile degistirebiliriz

```SQL
GO
ALTER PROC SP_First
AS
BEGIN
    SELECT Product.product_name
    from Product
END
GO


EXEC SP_First -- Calistirma komutu
```

- INT Tipinde Parametre Alan Proc
  - Verilen ID'ye sahip olan urunu getiren proc yazalim

```SQL
GO
CREATE PROC SP_GetByProductId
    (
    @productId INT
)
AS
BEGIN
    SELECT *
    FROM Product
    WHERE product_id=@productId
END
GO

SP_GetByProductId 55 -- Calistirma komutu
```

> `EXEC`, `EXECUTE` ve ya hic bir keyword girmeden de cagirabiliriyoruz.

- `SP_GetByProductId @productId= 9` => Bu sekilde de cagirabiliyoruz
- Birden fazla parametre alan proc
  - Verilen Kategorideki, verilen fiyatin altindaki urunleri getiren bir procedure yazalim

```SQL
GO
CREATE PROC SP_Product
    (
    @categoryId INT,
    @price MONEY
)
AS
BEGIN
    SELECT *
    FROM Product
    WHERE category_id=@categoryId and price<@price
END
GO

SP_Product 4, 150 -- Calistirma komutu
```

- Birden cok parametre gonderiliyorsa parametreleri virgul ile ayirabiliriz. Ya da parametrelerin adini yazabiliriz
