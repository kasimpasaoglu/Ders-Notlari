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

- Begin/End C#'taki parantez ac ve parantez kapa gibidir.
- Bunu Stored Procedures klasorune kaydeder
- `EXECUTE` Komutu ile bu SP cagrilabilir

```SQL
EXECUTE SP_First
```
