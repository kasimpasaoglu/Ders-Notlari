// Access Modifier bir uyeye erisimin nasil olacagini belirler.
/// public : Her yerden ve her katmandan bu uyeye erisim saglanabilir
/// /// Her uye icin verilebilir
/// /// Class-Metod-Prop-Ctor-Degiskenler access modifier alabilirler

/// private : Sadece o uyenin oldugu katmandan erisim saglanabilir
/// /// her uye icin verilebilir
/// /// classlar private olamazlar
/// /// private uyeler kalitim ile baska bir classa gitmez
/// /// erisim belirtec yazilmaz ise default erisim belirtec `private`dir

/// protected : yazilan uyenin, yazildigi sinif, baska bir sinifa kalitildigi zaman, yeni siniftan gorunebilir olmasini, onun disinda gorunmemesini saglar.
/// protected, private gibidir ancak tek farkli, kalitim yolu ile baska classlarda erisilebilir olmasini saglar. 

/// internal : Kutuphaneler icerisinde birbirine ulas, farkli kutuphane ise ulasma. 
/// /// Kutuphane nedir? (DLL kod kutuphanesi Ara Konu)
/// 