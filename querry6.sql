-- LEFT JOIN, RIGHT JOIN, CROSS JOIN
-- INNER JOIN ile iki ya da daha fazla tablo birlestiginde her iki tabloda da karsiligi olan kayitlar gelir. Yani bizim ornegimizde categoty_id sutunlarinin eslesmesi gerekir.
-- Categori tablosundaki bir kategoriye bagli olmayan, ya da hic bir urunun bagli olmadagi kategori, INNER JOIN ile getirilemez.
SELECT * FROM Product

INSERT INTO Product (product_id, product_name, price, stock, category_id)
VALUES (201, 'Tabak', 10, 10, 6)

-- LEFT JOIN; solda olan tabloyu referans olarak alir, ve o tablodaki verinin, JOIN'lenen tabloda verisi yoksa NULL deger verir.

SELECT c.category_name, c.category_id, p.product_name,p.category_id FROM Product p
LEFT JOIN Category c
ON c.category_id = p.category_id

-- Bu sorgu sonucunda, yeni ekledigimiz Tabak urunu de listeye gelecektir, categori id'si karsiligi bulunmadigi icin kategori kismi NULL gelecektir. Yani sol taraf olan product tablosundaki butun urunler gelecek, sag tarafta karsiligi yoksa bile getirip, sag tablodan geli veri yerine NULL gelecek.

-- RIGHT JOIN, Left Joinin tam tersi olarak calisir. Yani sagdaki tabloyu referans olarak alir. Yani bir kategoride urun yoksa kategori gelecek ama icinde urun gorunmeyecek.
SELECT c.category_name, c.category_id, p.product_name,p.category_id FROM Product p
RIGHT JOIN Category c
ON c.category_id = p.category_id

-- CROSS JOIN
-- Tablodaki iliskiye bakilmaksizin, tum kategoriler ile tum urunleri eslestirir, Carpim yapar.
SELECT Category.category_name, Product.product_name FROM Category
CROSS JOIN Product