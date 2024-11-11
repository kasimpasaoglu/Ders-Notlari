# `JOIN`

- Iki ya da daha cok tabloyu birlestirmek icin kullanilir.
- Birlestirilecek iki tabloda ortak bir kolon olmalidir. Birlestirme islemi bu ortak kolon uzerinden yapilir.
- `Inner Join`, `Left Join`, `Right Join` ve `Cross Join` olarak 4 farkli join yontemi vardir.

SYNTAX

```SQL
Select *, Category.category_name -- iki tablodan da getirilecek kolonlar belirlenir
FROM Category INNER JOIN Product -- FROM'dan sonra ilk tablo INNER JOIN'den sonra ikinci tablo verildi
ON Category.category_id = Product.category_id -- birlestirme islemi yapialcak yer gosterirlir.
```

:bulb: Tablo isimlerine alias verilebilir. `Product p` yaparak product yerine p, `Category c` yaparak category yerine c yazabiliriz;

```SQL
Select c.category_name, p.product_name 
FROM Category c INNER JOIN Product p ON c.category_id = p.category_id
```

>Hangi kategoride kac tane farkli urun var

```SQL
SELECT COUNT(*), category_name
FROM Category INNER JOIN Product
    ON Category.category_id = Product.category_id
GROUP BY (Category.category_name)
```

>Hangi kategoride toplam kac tane urun stokta var

```SQL
SELECT c.category_name, SUM(p.stock)
FROM Product p INNER JOIN Category c
    ON p.category_id = c.category_id
GROUP BY (c.category_name)
```

## `HAVING`

:warning: `WHERE` ile, gruplanmis bir sorguya sart ekleyemezsiniz.
Gruplama sorgularinda sart, `HAVING` ile eklenir. `HAVING` her zaman `GROUP BY` keywordunden sonra yazilir

>stok sayisi 1000'den az olanlan kategoriler gelsin

```SQL
SELECT c.category_name, SUM(p.stock)
FROM Product p INNER JOIN Category c
    ON p.category_id = c.category_id
GROUP BY (c.category_name)
HAVING SUM(p.stock) < 1000
```

>Icerdeki mallarin toplam fiyati nedir (stok*fiyat)

```SQL
Select SUM(price* stock) as 'Toplam Fiyat'
FROM Product
```

>Kategory bazli toplam urun tutari nedir

```SQL
SELECT c.category_name, SUM(p.price * p.stock) as 'Toplam Tutar'
FROM Product p INNER JOIN Category c
    ON p.category_id = c.category_id
GROUP BY (c.category_name)
ORDER BY 2 DESC
```

>En Cok urune sahip kategori hangisidir

```SQL
SELECT TOP (1)
    c.category_name, SUM(p.stock)
FROM Product p INNER JOIN Category c
    ON p.category_id = c.category_id
GROUP BY (c.category_name)
ORDER BY 2 DESC
```
