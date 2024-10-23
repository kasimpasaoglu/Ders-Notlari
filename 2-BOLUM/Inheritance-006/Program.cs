KaraTasiti arac = new();
arac.Kapasite = 4;
arac.Eneji = "Benzin";
arac.Hiz = 200;

Console.WriteLine(arac.Eneji);
Console.WriteLine(arac.Hiz);
Console.WriteLine(arac.Kapasite);

// -----------------------------------------------------------
//Banka ornegi

// classlara ait bir nesne ornegi alalim
Akbank akbank = new();
akbank.URL = "www.akbank.com";
Garanti garanti = new();
garanti.URL = "www.garanti.com";



Ziraat ziraat = new();
ziraat.Renk = "Kirmizi";
// renk propu sadece Ziraat classina ait digerlerinde yok

// -----------------------------------------------------------
// A clasi B Clasi


B be = new B();
be.Aciklama = "Tureyen sinif";
// bu hiyerarside, calisma zamaninda nasil bir bellek hareketi gerceklesir.
