# CONSTRAINTS

Kolonlara belirli kistlar getirmek amaci ile kolon bazli ayarlama yapilaridir.

## `PRIMATY KEY` ve `FOREING KEY` Constraintler

- Mevcut tabloya Primary Key Eklemek

```SQL
ALTER TABLE Category
ADD CONSTRAINT PK_CategoryId PRIMARY KEY(category_id)
```

- Bir tablonun id kolonunun primary key olmasi, o tabloda id alaninda benzersizlik saglar. Ayrica her kaydin Primary Key degerinden ayirt edilmesini saglar
- Id alani primary key olmasi sayesinde, veri aramalarinda id degeri uzerinden arama yapilmasi yuk hiz ve verimlilik saglar

- Foreing Key Constraint EKlemek
- Product tablosundaki category_id alanini Foreign Key yapalim

```SQL
ALTER TABLE Product
ADD CONSTRAINT FK_Product_Category FOREIGN KEY (category_id)
REFERENCES Category(category_id)
ON DELETE CASCADE
```

- Bir Primary Key ile birlikte calisir. Iliskisel tablolarda, her iki tabloyu fiziki olarak birbirine baglamak icin, primary key ve foreign key constraint kullanilir.
- Product tablosundaki category_id alani ile Category tablosundaki category_id alanini birbirine bagliyoruz,
- Category tablosundaki category_id alani Primary Key ve Product tablsoundaki categoty_id alani Foreign Key birbirine fiziksel olarak baglanmis oldu.
- :warning: `ON DELETE CASCADE`; Bir kategori silindiginde o kategoriye bagli olan tum urunleri sil!

>Deneme;

```SQL
INSERT INTO Product
    (product_id, product_name, price, stock, category_id)
VALUES
    (201, 'Tabak', 10, 10, 6)

-- Olmayan kategoride urun eklemeyi kabul etmedi,
```

- :warning: Ayrica categori tablosundan herhangi bir kategori silinirse product tablosunda o categoriye iliskili olan butun urunleri silecektir!

- ON DELETE SET NULL; Bu komutu girersek, Category silindigi zaman productlarin category_id kolonuna NULL degeri atar.
- ON DELETE RESTRICT; Category silindindiginde, ona bagli olan productlar var ise, silinmesini engeller.
- ON DELETE NO ACTION; Bu kural da, yukaridaki gibi isler.

- `UNIQUE` CONSTRAINT: Bir kolonu unique olarak belirlerseniz o kolonda bir veri tekrar edemez.
- Constraintler tablo olusturulurken verilebilecegi gibi sonradan da eklenebilir;

```SQL
ALTER TABLE Product
ADD CONSTRAINT Uq_Name UNIQUE (product_name)
```

-- Eger unique yapmak istenilen kolonda ayni degerler varsa hata verir

-- `CHECK` CONSTRAINT: Kolona girilecek olan veririnin belirli sartlar saglamasi kuralini koyabilecegimiz bir constraint'dir.

>price alani sifirdan kucuk olamaz yapalim

```SQL
ALTER TABLE Product
ADD CONSTRAINT CHK_Price CHECK (price > 0)
```

- `DEFAULT` CONSTRAINT: Uygulandigi kolona veri girilmedigi durumda, hangi verinin girilecegini belirler.
  - Yani veri girisi yapildiginda bir kolona veri girilmezse o kolon NULL olmak yerine default olarak belirleyecegimiz degeri alsin.

```SQL
ALTER TABLE Product
ADD InsertedDate DATETIME DEFAULT(GETDATE())
```

-`NOT NULL` CONSTRAINT: Verilen kolonun icinde NULL olmasini engellemek icin kullanilir.

```SQL
ALTER TABLE Product
ADD Tarih DATETIME DEFAULT(GETDATE()) NOT NULL
```
