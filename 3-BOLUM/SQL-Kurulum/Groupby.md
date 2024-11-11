# `Group By` Keyword

>Ayni Maasi alan kisilerin grup sayisi

```SQL
SELECT Maas, COUNT(Maas)
From Personel
Group BY Maas
```

>Adi ayni harfle baslayan kac kisi var

```SQL
SELECT SUBSTRING(Ad,1,1), COUNT(Ad)
FROM Personel
GROUP BY SUBSTRING(Ad,1,1)
```

>Ayni yilda dogmus kac kisi var

```SQL
SELECT DATEPART(YEAR,DogumTarihi), COUNT(*)
FROM Personel
GROUP BY DATEPART(YEAR, DogumTarihi)
```
