# Scope Kavrami

Kod yaziminda belli kisimlar {} parantezleri ile calistirilabilir. Bu parantelere scope denir.

* Scopelar icinde yazilan tanimlamalar, scope kapandigi zaman orda tanimlanmis veri disarda sorgulandigi zaman tanimsiz doner.
* Scoplar kapandigi zaman bellekten silinir.
* Ancak veri disarda tanimlanip, icerde islenebilir.
* ic ice yazilan scopelarda da ayni sey gecerlidir. Burda verinin hangi paranteze yazildigi onemli. En disardaki paranteze yazilan bilgi en icerdeki parantezden erisilebilir. Fakat en icerde yazilan bilgi bir ust parante icinden erisilmez.
* Bu yuzden gelistirme yaparken tum program icinde kullanilacak degiskenler en uste yazilmalidir. Tek seferlik kullanilacak bilgi sadece kullanilacagi scope icine yazilabilir.
--

> [**INDEX'e DON**](/README.md)
