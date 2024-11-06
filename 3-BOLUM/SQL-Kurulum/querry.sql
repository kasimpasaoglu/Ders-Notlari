
create database FirstDatabase

use FirstDatabase

create table Personel
(
	Id int,
	Ad nvarchar(20),
	Soyad nvarchar(20),
	TC nvarchar(11),
	Eposta nvarchar(30)
)


insert into Personel
	(Id,Ad,Soyad,TC,Eposta)
values(1, 'Kerem', 'Ayaz', '12345678901', 'test@kerem.com')

insert into Personel
	(Id,Ad,Soyad,TC,Eposta)
values(2, 'Selcuk', 'Dinc', '10987654321', 'test@selcuk.com')

select Id, Ad, Soyad, TC, Eposta
from Personel

select Ad, Eposta
from Personel

