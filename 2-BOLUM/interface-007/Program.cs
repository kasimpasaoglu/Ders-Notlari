/*
interface, yapisal itibariyle kalitim gibi gorunse de, aslinda miras alip verme durumu ya da siniflarin kendi iclerinde hiyerarsisi yoktur.

Interface: Yazilacak olan siniflara yon gostermek ve yazilacak olan siniflarin sablonu olmak icin vardir.
Interface yazilirken kesinlikle 'I' on eki ile yazilmalidir.
Ornek: IAraba, IOgrenci.

*/


// Bir interface pointeri kendisini implemet etmis tum siniflari isaret edebilir.

// IAraba araba = new Mercedes();

// interface ler kendi baslanarina new'lenemezler
IHavaTasit havatasit = new IHavaTasit();
// Ancak interface tipinde bir dizi yapilabilir
IHavaTasit[] havaTasit = new IHavaTasit[10];
// dizinin her bir index'ine bir pointer atamasi yapmis olduk
// bu pointerlari, bu interface'i kullanan classlara newleyerek nesle uretilebilir.
havaTasit[0] = new HoverCraft();