# SQL DEGISKEN TANIMLAMA

- C#'ta oldugu gibi SQL icinde de degerleri degiskenlere tanimlayabiliriz.

SYNTAX;

```SQL
DECLARE @max DECIMAL
SET @max = 10
SELECT @max
-- @max degiskenine atanan degeri ekrana gelecek.
```

> Sorgu sonucunu degiskene atama

```SQL
DECLARE @max DECIMAL
SELECT @max=MAX(price)
FROM Product
SELECT @max
```
