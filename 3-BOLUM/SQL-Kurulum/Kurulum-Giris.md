# Table Of Contents

- [Kurulum](#kurulum)
  - [DateBase Nedir](#datebase-nedir)
  - [Yeni DataBase Olusturma](#yeni-database-olusturma)

---

# Kurulum

>Docker icin kurulum;
>`docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourStrong!Passw0rd" -p 1433:1433 --name mssql_container -d mcr.microsoft.com/mssql/server:2022-latest`\
>Açıklama:
>
>- ACCEPT_EULA=Y: Microsoft’un kullanım şartlarını kabul ediyorsun.
>- SA_PASSWORD=YourStrong!Passw0rd: sa kullanıcısı için güçlü bir şifre belirlemen gerekli (şifre en az 8 karakter, büyük/küçük harf, rakam ve özel karakter içermeli).
>- -p 1433:1433: Konteynerin 1433 portunu ana makinenin 1433 portuna yönlendirir.
>- --name mssql_container: Konteynere bir isim verir (istediğin ismi kullanabilirsin).
>- -d: Konteyneri arka planda çalıştırır.

SQL server iki parcadan olusur

1. SQL Server Engine => Motor; tum veri tabani islemlerini yurutmekten sorumludur
2. SQL Server Management Studio  => SQL SMS; Motorla developeri haberlestirmek icin vardir. Bir editordur.

## DateBase Nedir

Onceki calismalarimza verileri hep bir degiskenlere atadir. Ancak burdaki veriler hep geciciydi. (RAM de tutuluyordu)
Ancak gercek hayatta uygulama kapansa bile verilerin kaybolmayacagi bir yere ihtiyac vardir. (Diske Yazma)\
Verileri bir txt dosyasinda bile yazabiliriz, bu da bir cesit veri tabaninir.
Ancak daha iliskisel(veriler arasinda iliskileri olan) ve buyuk verileri tutmak istedgimizde bunlari artik bir txt olarak tutamayiz. Ornegin Excel kullaniriz.\
Excel tarz islevleri yerine getirebiliyor olsada kullanim amaci olarak bu is icin yeterli degildir.
Burda ihtiyacimiz olan sey bir **veritabanidir** (DataBase)

Iliskisel veri tabani icin Turkiyede en cok kullanilan 3 adet database vardir

- MSSql => Microsoft
- MySql =>
- Oracle => Oracle

**SQL Nedir**: VeriTabani sorgulama dilidir.

**Neler yapacagiz?** MsSql ile calismalarimiz iki asamada gerceklesecek;

1. MsSql uzerinde veri tabanini SQL Dili ile sorgulayacagiz
2. C# ile MsSql server'i konusturacagiz.

>Farkli bir veri tutma yapisi olan NoSql veritabanlari da vardir.
Bunlar ozellestirilmis veri tabanlaridir. Mesela sadece bir veri tipi ile calisir.

Server name kismina 3 sey yazilabilir,
bilgisayarin ismi, localhost ve ya '.' konabilir.

Veri tabani kurarken;

1. DataBase olusturulur

2. Database icinde tablolar olusturulur. Birden fazla tablo olusabilir.
    - Bir tabloda personel bilgileri tutarken digerinde urunleri tutabiliriz
    - Tablolar satir ve kolonlardan(sutun) olusur.
    - kolonlar adlandirilir ve sonra satirlar olusturulup veri yazilir.

## Yeni DataBase Olusturma

Sol taraftaki Object Explorer'da DataBases e sag tiklayip new Database diyerek yeni acabiliyoruz.

Ancak biz kodlama ile database olusturacagiz.

```SQL
-- ilk kodumuzu yazalim.
create database FirstDatabase
```

Hali hazirda bir database var ise o database e gecis yapmak icin

```SQL
use FirstDatabase
```

veri tabaninda bir veriyi gostermek icin kullanacagimiz komut `Select`'tir

ilk select komutunu calistiralim.

```SQL
select 1
```

SQL Server'da kullanabilecegimiz bazi veri tipleri vardir.
Bu tiplerden bazilari;

1. int => sayisal deger tutmak icin
2. nvarchar => metinsel veri tutmak icin vardir. (string)
    - tanimlanirken uzunluk verilmesi gereklidir. bunun icin `nvarchar(10)`(10 karakter) ve ya `nvarchar(max)`(max tutabilecegi kadar).
:bulb: Ilk tabloyu olusturmak icin simdilik bu veri tipleri ile calismaya baslayacagiz.
