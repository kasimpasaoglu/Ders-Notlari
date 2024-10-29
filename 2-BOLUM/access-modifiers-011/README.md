# Table Of Contents

- [Access Medifiers](#access-medifiers)
  - [public](#public)
  - [private](#private)
  - [protected](#protected)
  - [internal](#internal)

# Access Medifiers

- Access Modifier bir uyeye erisimin nasil olacagini belirler.

## public

- Her yerden ve her katmandan bu uyeye erisim saglanabilir
- Her uye icin verilebilir
- Class-Metod-Prop-Ctor-Degiskenler access modifier alabilirler

## private

- Sadece o uyenin oldugu katmandan erisim saglanabilir
- Her uye icin verilebilir
- Classlar private olamazlar
- Private uyeler kalitim ile baska bir classa gitmez
- Erisim belirtec yazilmaz ise default erisim belirtec `private`dir

## protected

- Yazilan uyenin, yazildigi sinif, baska bir sinifa kalitildigi zaman, yeni siniftan gorunebilir olmasini, onun disinda gorunmemesini saglar.
- Protected, private gibidir ancak tek farkli, kalitim yolu ile baska classlarda erisilebilir olmasini saglar.

## internal

- Kutuphaneler icerisinde birbirine ulas, farkli kutuphane ise ulasma.
- Kutuphane nedir? [DLL kod kutuphanesi Ara Konu](/2-BOLUM/DLL-010-1/README.md)
