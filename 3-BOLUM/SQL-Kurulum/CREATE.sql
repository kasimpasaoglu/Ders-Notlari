CREATE TABLE Department
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentName NVARCHAR(40) UNIQUE NOT NULL
);

CREATE TABLE Personnel
(
    PersonnelId INT IDENTITY(1,1) NOT NULL,
    FirstName NVARCHAR(20) NOT NULL,
    LastName NVARCHAR(20) NOT NULL,
    NationalId NVARCHAR(11) UNIQUE CHECK( LEN(NationalId) = 11),
    Email NVARCHAR(30),
    Salary INT NOT NULL,
    BirthDate DATE NOT NULL,
    DepartmentId INT FOREIGN KEY REFERENCES dbo.Department(Id) NOT NULL
);

GO
CREATE TRIGGER trg_Personnel_Email
ON Personnel
AFTER INSERT
AS
BEGIN
    UPDATE p
    SET Email = i.FirstName + '.' + i.LastName + '@test.com'
    FROM Personnel p
    INNER JOIN inserted i ON p.PersonnelId = i.PersonnelId
    WHERE p.Email IS NULL;
END;

CREATE TABLE Category
(
    CategoryId INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(15) UNIQUE NOT NULL
);

CREATE TABLE Product
(
    ProductId INT IDENTITY(1,1) NOT NULL,
    ProductName NVARCHAR(50) NOT NULL,
    Price MONEY NOT NULL,
    Stock INT NOT NULL,
    InsertDate DATETIME DEFAULT(GETDATE()) NOT NULL,
    CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId) NOT NULL
);

INSERT INTO Department
    (DepartmentName)
VALUES
    ('Human Resources'),
    ('Finance'),
    ('IT'),
    ('Marketing'),
    ('Operations');

INSERT INTO Personnel
    (FirstName, LastName, NationalId, Salary, BirthDate, DepartmentId)
VALUES
    ('Ali', 'Yilmaz', '44875148458', 10500, '1992-01-05', 1),
    ('Ayse', 'Kaya', '22345678902', 9800, '1993-04-10', 2),
    ('Mehmet', 'Demir', '32345678903', 11000, '1989-07-15', 3),
    ('Zeynep', 'Celik', '42345678904', 9700, '1990-10-20', 4),
    ('Ahmet', 'Sahin', '52345678905', 10200, '1988-06-30', 5),
    ('Fatma', 'Arslan', '62345678906', 10000, '1991-12-10', 1),
    ('Burak', 'Koc', '72345678907', 9500, '1995-05-18', 2),
    ('Elif', 'Gunes', '82345678908', 12000, '1997-11-22', 3),
    ('Can', 'Bozkurt', '92345678909', 9000, '1980-08-12', 4),
    ('Serkan', 'Yildirim', '12345678910', 10500, '1992-09-25', 5),
    ('Gul', 'Erdogan', '22345678911', 10800, '1983-03-19', 1),
    ('Tuba', 'Kurt', '32345678912', 9200, '1996-02-15', 2),
    ('Emre', 'Cetin', '42345678913', 9500, '1994-11-05', 3),
    ('Busra', 'Polat', '52345678914', 10100, '1993-07-09', 4),
    ('Halil', 'Ozturk', '62345678915', 9800, '1991-06-28', 5),
    ('Melis', 'Aksoy', '72345678916', 11500, '1988-10-31', 1),
    ('Ugur', 'Kilic', '82345678917', 9400, '1985-05-20', 2),
    ('Cem', 'Eren', '92345678918', 10000, '1990-01-01', 3),
    ('Hulya', 'Kara', '12345678919', 10400, '1992-03-12', 4),
    ('Veli', 'Sarikaya', '22345678920', 9500, '1995-08-19', 5),
    ('Nazli', 'Erkan', '32345678921', 9700, '1991-04-03', 1),
    ('Efe', 'Aydin', '42345678922', 10500, '1993-06-17', 2),
    ('Selin', 'Gul', '52345678923', 11000, '1990-11-27', 3),
    ('Yusuf', 'Kaya', '62345678924', 9300, '1989-01-11', 4),
    ('Ebru', 'Deniz', '72345678925', 10200, '1997-09-14', 5),
    ('Mert', 'Altun', '82345678926', 9800, '1984-10-20', 1),
    ('Duygu', 'Can', '92345678927', 10700, '1988-12-05', 2),
    ('Sevda', 'Bulut', '12345678928', 9900, '1987-07-22', 3),
    ('Omer', 'Tan', '22345678929', 9700, '1986-04-06', 4),
    ('Gamze', 'Keskin', '32345678930', 10300, '1999-03-25', 5),
    ('Kerem', 'Ozgur', '42345678931', 10100, '1995-11-11', 1),
    ('Seda', 'Demir', '52345678932', 10600, '1994-08-08', 2),
    ('Tugce', 'Kara', '62345678933', 10900, '1993-05-19', 3),
    ('Samet', 'Yildiz', '72345678934', 9900, '1982-02-07', 4),
    ('Pelin', 'Ozkan', '82345678935', 10000, '1990-01-03', 5),
    ('Furkan', 'Kose', '92345678936', 10500, '1985-09-23', 1),
    ('Esra', 'Dag', '12345678937', 9700, '1987-06-29', 2),
    ('Sinan', 'Avci', '22345678938', 9500, '1992-04-01', 3);

-- SELECT * FROM Personnel

INSERT INTO Category
    (CategoryName)
VALUES
    ('Electronics'),
    ('Clothing'),
    ('Home Appliances'),
    ('Books'),
    ('Toys'),
    ('Groceries');

-- SELECT * FROM Category

INSERT INTO Product
    (ProductName, Price, Stock, CategoryId)
VALUES
    -- Electronics (50 products)
    ('Smartphone Model A', 599.99, 50, 1),
    ('Smartphone Model B', 749.99, 30, 1),
    ('Laptop Model X', 1199.99, 20, 1),
    ('Tablet Model Z', 299.99, 100, 1),
    ('Headphones Model 1', 99.99, 200, 1),
    ('Camera Model Q', 899.99, 40, 1),
    ('Smartwatch Model T', 179.99, 60, 1),
    ('Speaker Model X', 149.99, 150, 1),
    ('Drone Model A', 299.99, 15, 1),
    ('External Hard Drive', 89.99, 40, 1),
    ('Wi-Fi Extender', 29.99, 75, 1),
    ('VR Headset Model V', 249.99, 40, 1),
    ('E-Reader Model E', 129.99, 70, 1),
    ('Fitness Tracker', 59.99, 80, 1),
    ('Bluetooth Adapter', 19.99, 150, 1),
    ('Portable Charger', 19.99, 300, 1),
    ('Memory Card 64GB', 15.99, 250, 1),
    ('Smart Home Hub', 89.99, 100, 1),
    ('Smart TV 42"', 499.99, 50, 1),
    ('Smart TV 55"', 699.99, 40, 1),
    ('Gaming Console', 399.99, 25, 1),
    ('Router Model X', 49.99, 60, 1),
    ('Digital Camera', 299.99, 30, 1),
    ('Portable Speaker', 49.99, 80, 1),
    ('Gaming Headset', 79.99, 90, 1),
    ('Action Camera', 159.99, 35, 1),
    ('Wireless Earbuds', 39.99, 200, 1),
    ('Portable Projector', 249.99, 20, 1),
    ('USB Flash Drive', 9.99, 500, 1),
    ('Laptop Cooling Pad', 19.99, 150, 1),
    ('Phone Stand', 9.99, 300, 1),
    ('Webcam HD', 39.99, 50, 1),
    ('Smartphone Charger', 14.99, 400, 1),
    ('Smartphone Case', 9.99, 450, 1),
    ('Bluetooth Speaker', 59.99, 75, 1),
    ('Tablet Stand', 19.99, 200, 1),
    ('Smart Doorbell', 129.99, 40, 1),
    ('Fitness Smartwatch', 149.99, 55, 1),
    ('LED Strip Lights', 24.99, 100, 1),
    ('VR Controllers', 49.99, 60, 1),
    ('Wireless Charger', 29.99, 180, 1),
    ('Portable SSD', 99.99, 80, 1),
    ('Noise Cancelling Headphones', 199.99, 25, 1),
    ('Dash Cam', 89.99, 120, 1),
    ('Gaming Mouse', 49.99, 150, 1),
    ('Keyboard Mechanical', 79.99, 80, 1),
    ('Computer Monitor 24"', 149.99, 30, 1),
    ('Portable Monitor', 199.99, 40, 1),
    ('Memory Card 128GB', 29.99, 180, 1),

    -- Clothing (40 products)
    ('T-Shirt Model X', 19.99, 100, 2),
    ('Jeans Model A', 49.99, 80, 2),
    ('Jacket Model C', 99.99, 50, 2),
    ('Sweater Model S', 29.99, 70, 2),
    ('Shorts Model X', 24.99, 110, 2),
    ('Skirt Model A', 29.99, 40, 2),
    ('Dress Model B', 59.99, 30, 2),
    ('Blouse Model X', 39.99, 50, 2),
    ('Cardigan Model Y', 59.99, 40, 2),
    ('Sandals Model S', 49.99, 60, 2),
    ('Running Shoes', 59.99, 80, 2),
    ('Slippers Model S', 14.99, 100, 2),
    ('Polo Shirt', 34.99, 90, 2),
    ('Hoodie Model H', 39.99, 65, 2),
    ('Boots Model B', 119.99, 60, 2),
    ('Formal Pants', 45.99, 80, 2),
    ('Casual Shirt', 29.99, 150, 2),
    ('Summer Hat', 19.99, 70, 2),
    ('Beanie Model X', 14.99, 100, 2),
    ('Socks Pack', 9.99, 300, 2),
    ('Scarf Wool', 25.99, 60, 2),
    ('Gloves Winter', 15.99, 200, 2),
    ('Jeans Model B', 49.99, 90, 2),
    ('Trench Coat', 99.99, 45, 2),
    ('Raincoat Model R', 79.99, 60, 2),
    ('Belt Leather', 19.99, 120, 2),
    ('Handbag Leather', 89.99, 50, 2),
    ('Watch Classic', 199.99, 30, 2),
    ('Ring Gold Plated', 25.99, 150, 2),
    ('Bracelet Silver', 19.99, 200, 2),
    ('Cap Model Y', 12.99, 140, 2),
    ('Shoes Casual', 59.99, 90, 2),
    ('Dress Model C', 45.99, 70, 2),
    ('Formal Shoes', 129.99, 60, 2),
    ('Sunglasses Model A', 29.99, 150, 2),
    ('Sunglasses Model B', 24.99, 120, 2),
    ('Sneakers Model X', 69.99, 110, 2),
    ('Sports Bra', 24.99, 150, 2),
    ('Yoga Pants', 29.99, 80, 2),

    -- Home Appliances (30 products)
    ('Refrigerator Model R', 1200.00, 10, 3),
    ('Microwave Model M', 300.00, 25, 3),
    ('Washing Machine Model W', 800.00, 15, 3),
    ('Toaster Model T', 99.99, 30, 3),
    ('Nightstand Model Modern', 89.99, 28, 3),
    ('Bookshelf Model Large', 199.99, 12, 3),
    ('Dining Table Set Model X', 599.99, 8, 3),
    ('Patio Set Model Classic', 249.99, 12, 3),
    ('Wardrobe Model Compact', 299.99, 10, 3),
    ('Bed Frame Model Queen', 399.99, 12, 3),
    ('Armchair Model Comfort', 199.99, 20, 3),
    ('Blender Model B', 149.99, 25, 3),
    ('Dishwasher Model X', 999.99, 10, 3),
    ('Vacuum Cleaner Model V', 199.99, 50, 3),
    ('Air Purifier Model A', 299.99, 40, 3),
    ('Portable AC', 399.99, 30, 3),
    ('Kettle Model K', 29.99, 100, 3),
    ('Iron Model X', 49.99, 80, 3),
    ('Coffee Maker', 79.99, 60, 3),
    ('Electric Stove', 199.99, 20, 3),
    ('Space Heater', 89.99, 50, 3),
    ('Fan Model A', 29.99, 120, 3),
    ('Air Conditioner', 299.99, 15, 3),
    ('Humidifier', 59.99, 90, 3),
    ('Dehumidifier', 119.99, 30, 3),
    ('Blender Model X', 59.99, 110, 3),
    ('Rice Cooker', 79.99, 25, 3),
    ('Vacuum Cleaner Model X', 139.99, 40, 3),
    ('Oven Model A', 299.99, 12, 3),
    ('Water Dispenser', 129.99, 35, 3),

    -- Books (60 products)
    ('Novel - Midnight Secrets', 9.99, 120, 4),
    ('Science Fiction - Galactic Odyssey', 12.99, 100, 4),
    ('Historical Fiction - The Last Empress', 14.99, 80, 4),
    ('Fantasy Novel - Dragons of Evermore', 15.99, 75, 4),
    ('Thriller - The Silent Assassin', 10.99, 130, 4),
    ('Cookbook - World of Flavors', 18.99, 40, 4),
    ('Romance Novel - Love in Paris', 8.99, 150, 4),
    ('Biography - Life of Leonardo Da Vinci', 19.99, 60, 4),
    ('Graphic Novel - Heroes of Tomorrow', 12.99, 110, 4),
    ('Classic Novel - Pride and Prejudice', 9.99, 200, 4),
    ('Science Book - Quantum Mechanics', 21.99, 50, 4),
    ('Self-Help - The Power of Habit', 13.99, 200, 4),
    ('Children’s Book - The Adventure Club', 7.99, 170, 4),
    ('Thriller - The Vanishing Lake', 10.99, 130, 4),
    ('Poetry - Whispers of the Heart', 7.99, 140, 4),
    ('Non-Fiction - A Brief History of Time', 15.99, 100, 4),
    ('Mystery - The Silent Witness', 12.99, 90, 4),
    ('Children’s Book - The Magical Forest', 6.99, 180, 4),
    ('Biography - The Life of Steve Jobs', 18.99, 70, 4),
    ('Psychology - Thinking Fast and Slow', 16.99, 85, 4),
    ('Science Fiction - Beyond the Stars', 11.99, 120, 4),

    -- Toys (45 products)
    ('Action Figure - Hero X', 20.00, 250, 5),
    ('Board Game - Strategy Master', 40.00, 100, 5),
    ('Stuffed Animal - Teddy', 25.00, 180, 5),
    ('Building Blocks - Deluxe Set', 35.00, 140, 5),
    ('Puzzle - 1000 Pieces', 15.00, 190, 5),
    ('Toy Car Model T', 19.99, 200, 5),
    ('Dollhouse Model X', 89.99, 50, 5),
    ('Toy Train Set', 59.99, 60, 5),
    ('RC Car Model A', 49.99, 70, 5),
    ('Board Game - Family Fun', 29.99, 100, 5),
    ('Kite Model S', 9.99, 180, 5),
    ('Yo-Yo Model Z', 4.99, 300, 5),
    ('Drone - Mini', 129.99, 30, 5),
    ('Stuffed Animal - Bunny', 22.99, 150, 5),
    ('Toy Gun Model G', 29.99, 100, 5),
    ('Lego Set - Space Adventures', 69.99, 90, 5),
    ('Play-Doh Pack', 14.99, 150, 5),
    ('Action Figure - Villain Y', 24.99, 200, 5),
    ('Wooden Train Set', 59.99, 40, 5),
    ('Rubik’s Cube', 9.99, 300, 5),
    ('Toy Drone', 89.99, 50, 5),
    ('Teddy Bear', 19.99, 250, 5),
    ('Board Game - Trivia King', 39.99, 80, 5),
    ('Action Figure - Superhero Z', 29.99, 120, 5),
    ('Nerf Gun', 49.99, 100, 5),
    ('Remote Control Boat', 79.99, 60, 5),
    ('Toy Kitchen Set', 99.99, 40, 5),
    ('Stuffed Animal - Giraffe', 29.99, 100, 5),
    ('Foam Dart Blaster', 19.99, 220, 5),
    ('Doll - Fashion Model', 34.99, 150, 5),
    ('Building Blocks - Basic Set', 24.99, 200, 5),
    ('Toy Helicopter', 69.99, 70, 5),
    ('Action Figure - Robot Warrior', 39.99, 90, 5),
    ('Chess Set', 14.99, 300, 5),
    ('RC Truck', 59.99, 50, 5),
    ('Puzzle - 500 Pieces', 10.00, 210, 5),
    ('Magic Kit', 29.99, 140, 5),
    ('Water Gun', 9.99, 500, 5),
    ('Plush Unicorn', 25.99, 160, 5),
    ('Toy Workshop Set', 49.99, 80, 5),
    ('Board Game - Card Strategy', 19.99, 200, 5),

    -- Groceries (20 products)
    ('Rice - Premium Quality', 10.99, 500, 6),
    ('Milk - Fresh Dairy', 2.50, 1000, 6),
    ('Bread - Whole Wheat', 1.50, 800, 6),
    ('Coffee - Dark Roast', 7.99, 300, 6),
    ('Chocolate - Milk', 3.50, 400, 6),
    ('Milk - Skimmed', 2.20, 900, 6),
    ('Bread - Multigrain', 1.80, 700, 6),
    ('Pasta - Italian', 5.00, 600, 6),
    ('Juice - Orange', 3.99, 500, 6),
    ('Cereal - Honey Oats', 4.99, 450, 6),
    ('Eggs - Large Dozen', 2.99, 700, 6),
    ('Cheese - Cheddar Block', 5.99, 300, 6),
    ('Butter - Salted', 3.50, 500, 6),
    ('Frozen Pizza - Pepperoni', 6.99, 200, 6),
    ('Ice Cream - Vanilla', 4.50, 300, 6),
    ('Tea - Green', 3.99, 600, 6),
    ('Sauce - Tomato', 2.99, 500, 6),
    ('Snack Bar - Chocolate Chip', 1.99, 800, 6),
    ('Yogurt - Plain', 2.50, 900, 6),
    ('Cooking Oil - Olive', 9.99, 350, 6);

SELECT * FROM Product