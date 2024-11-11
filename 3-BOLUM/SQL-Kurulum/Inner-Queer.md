# INNER QUERY

- Bir sorgu icinde baska bir sorgu yapilabilir;

>Bir kategorideki en pahalli urun nedir

```SQL
SELECT c.category_name, p.product_name, p.price
FROM Category c INNER JOIN Product p
    ON p.category_id= c.category_id
WHERE p.price = (SELECT MAX(price)
from Product)
```

>Her kategorideki en pahali urun

```SQL
SELECT c.category_name, p.product_name, p.price
FROM Category c INNER JOIN Product p
    ON p.category_id= c.category_id
WHERE p.price = (SELECT MAX(price)
from Product p2
where p2.category_id=c.category_id)
```
