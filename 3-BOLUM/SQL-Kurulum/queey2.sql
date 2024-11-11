DROP TABLE Personel
CREATE TABLE Personel
(
    Id int,
    Ad nvarchar(20),
    Soyad nvarchar(20),
    TC nvarchar(11),
    Eposta nvarchar(30),
    Maas int,
    DogumTarihi DATETIME
)
-- GROUP BY
-- Ayni Maasi alan kisilerin grup sayisi
SELECT Maas, COUNT(Maas)
From Personel
Group BY Maas

-- Adi ayni harfle baslayan kac kisi var 
SELECT SUBSTRING(Ad,1,1), COUNT(Ad)
FROM Personel
GROUP BY SUBSTRING(Ad,1,1)

--Ayni yilda dogmus kac kisi var
SELECT DATEPART(YEAR,DogumTarihi), COUNT(*)
FROM Personel
GROUP BY DATEPART(YEAR, DogumTarihi)



-- CREATE TABLE Category
-- (
--     category_id INT,
--     category_name NVARCHAR(100)
-- );

INSERT INTO Category
    (category_id ,category_name)
VALUES
    (1, 'Electronics'),
    (2, 'Clothing'),
    (3, 'Furniture'),
    (4, 'Sports'),
    (5, 'Books');


-- CREATE TABLE Product
-- (
--     product_id INT,
--     product_name NVARCHAR(100) NOT NULL,
--     price DECIMAL(10, 2) NOT NULL,
--     stock INT NOT NULL,
--     category_id INT,

-- );

INSERT INTO Product
    (product_id, product_name, price, stock, category_id)
VALUES
    -- Electronics kategorisi (product_id 1-40)
    (1, 'Smartphone Model A', 599.99, 50, 1),
    (2, 'Smartphone Model B', 749.99, 30, 1),
    (3, 'Laptop Model X', 1199.99, 20, 1),
    (4, 'Tablet Model Z', 299.99, 100, 1),
    (5, 'Headphones Model 1', 99.99, 200, 1),
    (6, 'Headphones Model 2', 149.99, 150, 1),
    (7, 'Smartwatch Model S', 199.99, 75, 1),
    (8, 'Smartwatch Model T', 179.99, 60, 1),
    (9, 'Camera Model Q', 899.99, 40, 1),
    (10, 'Camera Model R', 999.99, 35, 1),
    (11, 'TV Model A', 499.99, 45, 1),
    (12, 'TV Model B', 699.99, 30, 1),
    (13, 'Speaker Model X', 149.99, 150, 1),
    (14, 'Speaker Model Y', 199.99, 140, 1),
    (15, 'Drone Model A', 299.99, 15, 1),
    (16, 'Drone Model B', 349.99, 12, 1),
    (17, 'Router Model X', 79.99, 60, 1),
    (18, 'Router Model Y', 89.99, 55, 1),
    (19, 'Console Model Z', 399.99, 20, 1),
    (20, 'Keyboard Model K', 49.99, 80, 1),
    (21, 'Mouse Model M', 29.99, 90, 1),
    (22, 'Monitor Model 24"', 149.99, 70, 1),
    (23, 'Monitor Model 27"', 199.99, 50, 1),
    (24, 'Printer Model X', 99.99, 25, 1),
    (25, 'Scanner Model Y', 129.99, 30, 1),
    (26, 'Webcam Model W', 49.99, 120, 1),
    (27, 'Projector Model P', 299.99, 10, 1),
    (28, 'VR Headset Model V', 249.99, 40, 1),
    (29, 'Smart Home Hub', 89.99, 100, 1),
    (30, 'E-Reader Model E', 129.99, 70, 1),
    (31, 'Portable Charger', 19.99, 300, 1),
    (32, 'Fitness Tracker', 59.99, 80, 1),
    (33, 'Digital Frame', 49.99, 90, 1),
    (34, 'Bluetooth Adapter', 19.99, 150, 1),
    (35, 'External Hard Drive', 89.99, 40, 1),
    (36, 'USB Flash Drive', 9.99, 200, 1),
    (37, 'Network Switch', 59.99, 50, 1),
    (38, 'Wi-Fi Extender', 29.99, 75, 1),
    (39, 'Memory Card', 14.99, 250, 1),
    (40, 'Portable Speaker', 39.99, 100, 1),
    (41, 'T-Shirt Model X', 19.99, 100, 2),
    (42, 'T-Shirt Model Y', 24.99, 120, 2),
    (43, 'Jeans Model A', 49.99, 80, 2),
    (44, 'Jacket Model C', 99.99, 50, 2),
    (45, 'Sweater Model S', 29.99, 70, 2),
    (46, 'Hoodie Model H', 39.99, 65, 2),
    (47, 'Polo Shirt', 34.99, 90, 2),
    (48, 'Shorts Model X', 24.99, 110, 2),
    (49, 'Skirt Model A', 29.99, 40, 2),
    (50, 'Dress Model B', 59.99, 30, 2),
    (51, 'Sneakers Model S', 79.99, 100, 2),
    (52, 'Boots Model B', 119.99, 60, 2),
    (53, 'Socks Model S', 9.99, 300, 2),
    (54, 'Belt Model X', 14.99, 100, 2),
    (55, 'Scarf Model Y', 19.99, 50, 2),
    (56, 'Hat Model A', 14.99, 40, 2),
    (57, 'Cap Model B', 9.99, 120, 2),
    (58, 'Blouse Model X', 39.99, 50, 2),
    (59, 'Cardigan Model Y', 59.99, 40, 2),
    (60, 'Coat Model Z', 149.99, 30, 2),
    (61, 'Gloves Model A', 19.99, 90, 2),
    (62, 'Leggings Model L', 29.99, 75, 2),
    (63, 'Sandals Model S', 49.99, 60, 2),
    (64, 'Swimsuit Model A', 34.99, 70, 2),
    (65, 'Bikini Model B', 29.99, 60, 2),
    (66, 'Sunglasses Model S', 49.99, 40, 2),
    (67, 'Watch Model W', 79.99, 25, 2),
    (68, 'Bag Model B', 99.99, 50, 2),
    (69, 'Backpack Model P', 49.99, 80, 2),
    (70, 'Umbrella Model U', 14.99, 100, 2),
    (71, 'Tie Model T', 19.99, 90, 2),
    (72, 'Bow Tie Model B', 24.99, 80, 2),
    (73, 'Formal Shoes', 129.99, 30, 2),
    (74, 'Casual Shoes', 79.99, 50, 2),
    (75, 'Running Shoes', 89.99, 70, 2),
    (76, 'Slippers Model S', 14.99, 100, 2),
    (77, 'Necklace Model N', 49.99, 40, 2),
    (78, 'Bracelet Model B', 29.99, 60, 2),
    (79, 'Earrings Model E', 19.99, 80, 2),
    (80, 'Ring Model R', 34.99, 90, 2),
    (81, 'Sofa Model Classic', 399.99, 10, 3),
    (82, 'Sofa Model Modern', 499.99, 5, 3),
    (83, 'Armchair Model Deluxe', 199.99, 20, 3),
    (84, 'Armchair Model Comfort', 179.99, 15, 3),
    (85, 'Dining Table Set Model X', 599.99, 8, 3),
    (86, 'Dining Table Set Model Y', 699.99, 7, 3),
    (87, 'Coffee Table Model A', 99.99, 30, 3),
    (88, 'Coffee Table Model B', 129.99, 25, 3),
    (89, 'Bed Frame Model Queen', 399.99, 12, 3),
    (90, 'Bed Frame Model King', 499.99, 10, 3),
    (91, 'Nightstand Model Classic', 79.99, 35, 3),
    (92, 'Nightstand Model Modern', 89.99, 28, 3),
    (93, 'Bookshelf Model Small', 149.99, 18, 3),
    (94, 'Bookshelf Model Large', 199.99, 12, 3),
    (95, 'Wardrobe Model Compact', 299.99, 10, 3),
    (96, 'Wardrobe Model Spacious', 399.99, 8, 3),
    (97, 'TV Stand Model Basic', 89.99, 20, 3),
    (98, 'TV Stand Model Advanced', 119.99, 15, 3),
    (99, 'Desk Model Office', 149.99, 25, 3),
    (100, 'Desk Model Home', 129.99, 30, 3),
    (101, 'Chair Model Office', 49.99, 50, 3),
    (102, 'Chair Model Dining', 39.99, 60, 3),
    (103, 'Recliner Model Comfort', 299.99, 10, 3),
    (104, 'Recliner Model Lux', 349.99, 8, 3),
    (105, 'Dresser Model Compact', 199.99, 15, 3),
    (106, 'Dresser Model Large', 249.99, 10, 3),
    (107, 'Cabinet Model Storage', 129.99, 20, 3),
    (108, 'Cabinet Model Display', 159.99, 18, 3),
    (109, 'Stool Model Kitchen', 29.99, 40, 3),
    (110, 'Stool Model Bar', 39.99, 35, 3),
    (111, 'Patio Set Model Classic', 249.99, 12, 3),
    (112, 'Patio Set Model Modern', 299.99, 10, 3),
    (113, 'Bench Model Garden', 89.99, 18, 3),
    (114, 'Bench Model Park', 109.99, 15, 3),
    (115, 'Mirror Model Wall', 59.99, 25, 3),
    (116, 'Mirror Model Full-Length', 99.99, 20, 3),
    (117, 'Drawer Model Basic', 79.99, 30, 3),
    (118, 'Drawer Model Advanced', 119.99, 25, 3),
    (119, 'Side Table Model Small', 49.99, 40, 3),
    (120, 'Side Table Model Large', 69.99, 35, 3),
    (121, 'Basketball', 24.99, 100, 4),
    (122, 'Soccer Ball', 19.99, 120, 4),
    (123, 'Tennis Racket', 49.99, 60, 4),
    (124, 'Badminton Set', 29.99, 75, 4),
    (125, 'Golf Clubs Set', 199.99, 15, 4),
    (126, 'Yoga Mat', 15.99, 200, 4),
    (127, 'Boxing Gloves', 39.99, 50, 4),
    (128, 'Baseball Bat', 29.99, 40, 4),
    (129, 'Baseball Glove', 24.99, 55, 4),
    (130, 'Volleyball', 17.99, 90, 4),
    (131, 'Table Tennis Paddle', 14.99, 150, 4),
    (132, 'Cricket Bat', 34.99, 30, 4),
    (133, 'Running Shoes', 59.99, 80, 4),
    (134, 'Cycling Helmet', 49.99, 40, 4),
    (135, 'Swim Goggles', 9.99, 120, 4),
    (136, 'Dumbbell Set', 69.99, 25, 4),
    (137, 'Jump Rope', 7.99, 200, 4),
    (138, 'Hiking Backpack', 49.99, 35, 4),
    (139, 'Treadmill', 299.99, 10, 4),
    (140, 'Elliptical Machine', 399.99, 8, 4),
    (141, 'Rowing Machine', 349.99, 6, 4),
    (142, 'Kettlebell 10kg', 29.99, 50, 4),
    (143, 'Resistance Bands Set', 19.99, 100, 4),
    (144, 'Foam Roller', 14.99, 80, 4),
    (145, 'Punching Bag', 89.99, 15, 4),
    (146, 'Kayak Paddle', 59.99, 20, 4),
    (147, 'Snowboard', 199.99, 12, 4),
    (148, 'Ski Poles', 49.99, 25, 4),
    (149, 'Surfboard', 299.99, 10, 4),
    (150, 'Skateboard', 79.99, 30, 4),
    (151, 'Rollerblades', 89.99, 40, 4),
    (152, 'Fishing Rod', 39.99, 60, 4),
    (153, 'Camping Tent', 99.99, 20, 4),
    (154, 'Sleeping Bag', 39.99, 75, 4),
    (155, 'Mountain Bike', 249.99, 15, 4),
    (156, 'Soccer Shin Guards', 14.99, 110, 4),
    (157, 'Tennis Balls (Pack of 3)', 5.99, 200, 4),
    (158, 'Basketball Hoop', 149.99, 8, 4),
    (159, 'Golf Balls (Pack of 12)', 19.99, 140, 4),
    (160, 'Weightlifting Belt', 29.99, 50, 4),
    (161, 'Mystery Novel - Midnight Secrets', 9.99, 120, 5),
    (162, 'Science Fiction - Galactic Odyssey', 12.99, 100, 5),
    (163, 'Historical Fiction - The Last Empress', 14.99, 80, 5),
    (164, 'Romance Novel - Love in Paris', 8.99, 150, 5),
    (165, 'Biography - Life of Leonardo Da Vinci', 19.99, 60, 5),
    (166, 'Self-Help - The Power of Habit', 13.99, 200, 5),
    (167, 'Fantasy Novel - Dragons of Evermore', 15.99, 75, 5),
    (168, 'Thriller - The Silent Assassin', 10.99, 130, 5),
    (169, 'Non-Fiction - A Brief History of Time', 16.99, 90, 5),
    (170, 'Children’s Book - The Adventure Club', 7.99, 170, 5),
    (171, 'Graphic Novel - Heroes of Tomorrow', 12.99, 110, 5),
    (172, 'Science - Quantum Mechanics Basics', 21.99, 50, 5),
    (173, 'Cookbook - World of Flavors', 18.99, 40, 5),
    (174, 'Psychology - Thinking Fast and Slow', 17.99, 85, 5),
    (175, 'Self-Help - Atomic Habits', 13.99, 140, 5),
    (176, 'Classic Novel - Pride and Prejudice', 9.99, 200, 5),
    (177, 'Horror - Nightfall Manor', 11.99, 120, 5),
    (178, 'Romance - The Enchanted Garden', 8.99, 150, 5),
    (179, 'Science Fiction - Beyond the Stars', 12.99, 100, 5),
    (180, 'Fantasy - The Shadow Realm', 15.99, 90, 5),
    (181, 'Mystery - The Vanishing Lake', 10.99, 130, 5),
    (182, 'Biography - The Life of Steve Jobs', 18.99, 70, 5),
    (183, 'Children’s Book - The Magical Forest', 6.99, 160, 5),
    (184, 'Health - The Plant-Based Diet', 14.99, 80, 5),
    (185, 'Poetry - Whispers of the Heart', 7.99, 140, 5),
    (186, 'Graphic Novel - Alien Encounters', 13.99, 75, 5),
    (187, 'Travel - A Guide to Europe', 19.99, 55, 5),
    (188, 'Business - The Lean Startup', 16.99, 65, 5),
    (189, 'Historical - The Fall of Empires', 11.99, 125, 5),
    (190, 'Science - Introduction to Genetics', 20.99, 45, 5),
    (191, 'Children’s Book - Dino Adventures', 5.99, 190, 5),
    (192, 'Classic - Moby Dick', 9.99, 160, 5),
    (193, 'Horror - Shadows in the Dark', 10.99, 140, 5),
    (194, 'Fantasy - The Lost Kingdom', 14.99, 100, 5),
    (195, 'Science Fiction - The Omega Protocol', 12.99, 115, 5),
    (196, 'Self-Help - Mindfulness for Beginners', 13.99, 130, 5),
    (197, 'Biography - Frida Kahlo: A Life', 17.99, 85, 5),
    (198, 'Cookbook - Vegan Delights', 18.99, 70, 5),
    (199, 'Non-Fiction - The Art of War', 11.99, 180, 5),
    (200, 'Poetry - Reflections of the Soul', 8.99, 155, 5);


-- JOIN 
-- Iki ya da daha cok tabloyu birlestirmek
-- Inner Join, Left Join, Right Join ve Cross Join olarak 4 farkli join yontemi vardir

Select *, Category.category_name
-- iki tablodan da getirilecek kolonlar belirlenir
FROM Category INNER JOIN Product -- FROM'dan sonra ilk tablo INNER JOIN'den sonra ikinci tablo verildi
    ON Category.category_id = Product.category_id
-- birlestirme islemi yapialcak yer gosterirlir.

-- NOT:Tablo isimlerine alias verilebilir. `Product p` yaparak product yerine p, `Category c` yaparak category yerine c yazabiliriz;
-- Select c.category_name, p.product_name 
-- FROM Category c INNER JOIN Product p ON c.category_id = p.category_id

--hangi kategoride kac tane farkli urun var
SELECT COUNT(*), category_name
FROM Category INNER JOIN Product
    ON Category.category_id = Product.category_id
GROUP BY (Category.category_name)

-- hangi kategoride toplam kac tane urun stokta var
SELECT c.category_name, SUM(p.stock)
FROM Product p INNER JOIN Category c
    ON p.category_id = c.category_id
GROUP BY (c.category_name)

-- stok sayisi 1000'den az olanlan kategoriler gelsin
-- where ile gruplanmis bir sorguya sart ekleyemezsiniz.
-- Gruplama sorgularinda sart, `HAVING` ile eklenir. `HAVING` her zaman `GROUP BY` keywordunden sonra yazilir

SELECT c.category_name, SUM(p.stock)
FROM Product p INNER JOIN Category c
    ON p.category_id = c.category_id
GROUP BY (c.category_name)
HAVING SUM(p.stock) < 1000

-- Icerdeki mallarin toplam fiyati nedir (stok*fiyat)
Select SUM(price* stock) as 'Toplam Fiyat'
FROM Product

-- Kategory bazli toplam urun tutari
SELECT c.category_name, SUM(p.price * p.stock) as 'Toplam Tutar'
FROM Product p INNER JOIN Category c
    ON p.category_id = c.category_id
GROUP BY (c.category_name)
ORDER BY 2 DESC

-- En Cok urune sahip kategori hangisidir
SELECT TOP (1)
    c.category_name, SUM(p.stock)
FROM Product p INNER JOIN Category c
    ON p.category_id = c.category_id
GROUP BY (c.category_name)
ORDER BY 2 DESC

-- INNER QUERY 
-- Bir kategorideki en pahalli urun nedir
SELECT c.category_name, p.product_name, p.price
FROM Category c INNER JOIN Product p
    ON p.category_id= c.category_id
WHERE p.price = (SELECT MAX(price)
from Product)


-- Her kategorideki en pahali urun
SELECT c.category_name, p.product_name, p.price
FROM Category c INNER JOIN Product p
    ON p.category_id= c.category_id
WHERE p.price = (SELECT MAX(price)
from Product p2
where p2.category_id=c.category_id)

-- tek sorguda en pahalli urun ve en ucuz urunu getirelim
--ODEV
SELECT c.category_name, p.product_name, p.price AS 'EN PAHALLI FIYAT', p.product_name, p.price AS 'EN UCUZ FIYAT'
FROM Category c INNER JOIN Product p
    ON p.category_id= c.category_id
    INNER JOIN Product p2
    ON p2.category_id=c.category_id
WHERE p.price = 
(SELECT MAX(price)
    from Product p2
    where p2.category_id=c.category_id)
    AND p.price = 
(SELECT MIN(price)
    from Product p2
    where p2.category_id=c.category_id)

-- SQL DEGISKEN TANIMLAMA

-- DECLARE @max DECIMAL
-- SET @max = 10
-- SELECT @max

-- sorgu sonucunu degiskene atama
DECLARE @max DECIMAL
SELECT @max=MAX(price)
FROM Product
SELECT @max

DECLARE @enPahaliUrunAdi NVARCHAR(MAX)
DECLARE @enUcuzUrunAdi NVARCHAR(MAX)
DECLARE @kategori NVARCHAR(MAX)
DECLARE @enUcuzFiyat MONEY
DECLARE @enPahaliFiyat MONEY

SELECT @enPahaliFiyat = MAX(price)
FROM Product
SELECT @enUcuzFiyat = MIN(price)
FROM Product


SELECT @enPahaliFiyat, @enUcuzFiyat

--STORE PROCEDURE
-- SQL'deki metodlardir.
-- Belirli kod bloklarini store procedure olarak yazip daha sonra calistirabiliriz.
-- Bir store procedure yazalim

-- CREATE PROCEDURE SP_First
-- AS
-- BEGIN
--     SELECT *
--     FROM Product
-- END

-- Begin/End C#'taki parantez ac ve parantez kapa gibidir.
-- Bunu Stored Procedures klasorune kaydeder
-- Calistirmak icin 

-- EXECUTE SP_First

-- Performansi kotu etkileyecek olan karmasik bir sorgu yapilacaksa kesinlikle Store Procedure yazilmasi tavsiye edilir. Cunku SQL bu sayede bu sorguyu yapabilmek icin gerekli ilk 3 adimi hafizaye onceden atmis olur. Geriye sadece sonuclari getirme kismi kalir

