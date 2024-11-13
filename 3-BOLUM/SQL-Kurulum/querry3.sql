USE azuredb

-- Yazilmis bir procedure'u alter komutu ile degistirebiliriz
GO
ALTER PROC SP_First
AS
BEGIN
    SELECT Product.product_name
    from Product
END
GO
EXEC SP_First

-- INT Tipinde Parametre Alan Proc

-- Verilen ID'ye sahip olan urunu getiren proc yazalim
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
-- Cagiralim;

SP_GetByProductId 55

-- > `EXEC`, `EXECUTE` ve ya hic bir keyword girmeden de cagirabiliriyoruz.

-- Daha okunakli diger yontem

-- SP_GetByProductId @productId= 9

-- Birden fazla parametre alan proc

-- Verilen Kategorideki, verilen fiyatin altindaki urunleri getiren bir procedure yazalim

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

-- birden cok parametre gonderiliyorsa parametreleri virgul ile ayirabiliriz. Ya da parametrelerin adini yazabiliriz

-- SP_Product 4, 150

--Ornek; Sports kategorisindeki urunleri JOIN yapmadan listeleyen Bir SP yazalim. SP parametre olarak direk NVARCHAR cinsinden categoryname parametresi alsin 

GO
CREATE PROC SP_FilterByCategory
    (
    @categoryName  NVARCHAR(MAX)
)
AS
BEGIN
    SELECT *
    FROM Product
    WHERE category_id = (SELECT category_id
    FROM Category
    WHERE category_name = @categoryName)
END
GO


EXEC SP_FilterByCategory 'Sports'


-- Diger bir yontem olarak degisken kullanabiliriz

GO
CREATE PROC SP_FilterByCategory2
    (
    @categoryName  NVARCHAR(MAX)
)
AS
BEGIN
    DECLARE @category_id INT

    SELECT @category_id= category_id
    FROM Category
    WHERE category_name=@categoryName

    SELECT *
    FROM Product
    WHERE category_id=@category_id
END
GO

EXEC SP_FilterByCategory2 'Sports'

------ ARA KONU
-- Yukardaki SP'nin icibdeki categy tablosu sorgusunda eger verilen kategory name alaninda bir kategori yoksa?
-- SQL'de if ve else bulunmaktadir.

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

-- IF komutuna ek olarak `EXISTS` keywordu'u kullanilabilir

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

-- Yeni ogrendigimiz if ve exists komutlari ile uygulayalim
--Asagidaki categoryname parametre verilen sorgudan geriye bir category id degeri cikmaktadir
-- bizde bu degeri bir sonraki sorguda kullanmak icin bir degisken uzerine aldik
-- @category_id degeri bir degiskendir
GO
CREATE PROC SP_Category2
    (
    @categoryName NVARCHAR(MAX)
)
AS
BEGIN
    DECLARE @category_id INT
    IF EXISTS (SELECT category_id
    from Category
    where category_name=@categoryName)
    BEGIN
        SELECT @category_id=category_id
        FROM Category

        SELECT *
        FROM Product
        WHERE category_id=@category_id
    END
    ELSE
    BEGIN
        SELECT 'Kategori Bulunamadi'
    END
END
GO

SP_Category2 'Books'

-- sistemde olan hazir prosedurler sayesinde bir cok islem yapilabilir

-- `sp_help` ve `sp_helptext` proclari ile bir procun icine ve bilgilerine bakabiliriz

-- ODEV: Yazdigimiz metodunun icini kimse gormesin istiyorsak bir encrypted procedure olarak yapabiliyoruz.  

-- Veritabani Dosya Sistemi
-- Veritabani dosya sistemi iki dosyadan olusur. LDF uzantili dosya log dosyasidir. Yapilan tum islemlere ait log kayitlari burda tutulur. Digeri MDF uzantili dosya ise verilerin durdugu yerdir.
-- Log dosyasi oldugu icin LDF uzantili dosya daha buyuktur ve daha cok yer kaplar. Bu yuzden bazen `shrink` yapilir. Yani log dosyasi silinir. 
-- MDF ve LDF dosyalarina ek olarak NDF dosyasi olabilir. 
-- SQL'de tablolar cok buyukse tablo performansini arttirmak icin SQL Partition yapilabilir.
-- SQL Partition bir tablo icindeki verileri parcalara bolmektir.
-- Partition yapildiginda her bir partition'un durdugu fiziksel dosyalar NDF'tir.

