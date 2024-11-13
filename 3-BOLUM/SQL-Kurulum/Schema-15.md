# SCHEMA Kavrami

- :bulb: Tablo, SP ya da Function olusturdugumuzda basina bir `dbo.` on eki gelir. DBO bir semadir. Her tablonun, functionun ve SP nin semalari olur. Standart sema aksi belirtilmedikce dbo'dur.
- Sema konusu C#'taki namespace kavramina benzer.
- Sema ayni isimli tablolari ya da diger yapilari olusturmak icin vardir. Olusturulan iki ayni isimli yapi, normalde hata verir ancak bu iki tablo farkli semalarda tutulursa hata vermeyecektir.
- Kendi semamizi olusturalim

```SQL
CREATE SCHEMA csharp

-- olusturdugumuz yeni semayi kullanan bir funcion yazalim

CREATE FUNCTION csharp.Fn_StokTopla(@stok INT, @price MONEY)
RETURNS money
AS
BEGIN
DECLARE @toplam MONEY
SET @toplam = @stok*@price
RETURN @toplam
END
```

- Bu metodu kullanirken schema belirtmek gerekir

```SQL
SELECT product_name, stock, price, csharp.Fn_StokTopla(stock, price) AS 'Toplam Tutar' FROM Product
```

- Sema nerelerde kullanilir?
- Veri tabanlari genelde karisiktir. Hangi tablonun nereye ait oldugunu anlamak genelde zordur.
- Sema tablolari bolume gore(yaptigi ise gore) ayirmak icin kullanilabilir.
