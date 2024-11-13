# IF & Else

```SQL
DECLARE @sayi1 INT
DECLARE @sayi2 INT

SET @sayi1=30
SET @sayi2=20

IF(@sayi1<@sayi2)
BEGIN
    SELECT 'sayi1 daha kucuk'
END
ELSE
BEGIN
    SELECT 'sayi2 daha kucuk'
END
```

- IF komutuna ek olarak `EXISTS` keywordu'u kullanilabilir

```SQL
IF EXISTS (SELECT *
FROM Product
WHERE product_id=1000)
BEGIN
    SELECT *
    FROM Product
    WHERE product_id=1000
END
ELSE
BEGIN
    SELECT 'Sonuc Yok!'
END
```

- Yeni ogrendigimiz if ve exists komutlari ile uygulayalim
- Asagidaki categoryname parametre verilen sorgudan geriye bir category id degeri cikmaktadir. Biz de bu degeri bir sonraki sorguda kullanmak icin bir degisken uzerine aldik
- @category_id degeri bir degiskendir

```SQL
CREATE PROC SP_Category2
(
    @categoryName NVARCHAR(MAX)             -- Parametreler
)
AS
BEGIN
    DECLARE @category_id INT                -- Degisken tanimi
    IF EXISTS (SELECT category_id
    from Category
    where category_name=@categoryName)      -- Eger parantez icindeki sorgu varsa
    BEGIN                                   -- burdaki kod blogu calisacak
        SELECT @category_id=category_id
        FROM Category

        SELECT *
        FROM Product
        WHERE category_id=@category_id
    END
    ELSE                                    -- Eger yoksa
    BEGIN                                   -- burdaki kod blogu calisacak
        SELECT 'Kategori Bulunamadi'
    END
END

SP_Category2 'Books'                        -- Calistirma komutu
```

- Sistemde olan hazir prosedurler sayesinde bir cok islem yapilabilir
- `sp_help` ve `sp_helptext` proclari ile bir procun icine ve bilgilerine bakabiliriz
- ODEV: Yazdigimiz metodunun icini kimse gormesin istiyorsak bir encrypted procedure olarak yapabiliyoruz.

## VeriTabani Dosya Sistemi (Ara Bilgi)

- Veritabani dosya sistemi iki dosyadan olusur. LDF uzantili dosya log dosyasidir. Yapilan tum islemlere ait log kayitlari burda tutulur. Digeri MDF uzantili dosya ise verilerin durdugu yerdir.
- Log dosyasi oldugu icin LDF uzantili dosya daha buyuktur ve daha cok yer kaplar. Bu yuzden bazen `shrink` yapilir. Yani log dosyasi silinir.
- MDF ve LDF dosyalarina ek olarak NDF dosyasi olabilir.
- SQL'de tablolar cok buyukse tablo performansini arttirmak icin SQL Partition yapilabilir.
- SQL Partition bir tablo icindeki verileri parcalara bolmektir.
- Partition yapildiginda her bir partition'un durdugu fiziksel dosyalar NDF'tir.
