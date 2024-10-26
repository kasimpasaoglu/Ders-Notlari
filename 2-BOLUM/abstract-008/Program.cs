// Abstract intarface gibidir, yani diger classlara sablonluk yapar. Ancak Interface'den farki sablonluk yaparken zorunlu kosulan ya da kosulmayan metodlarin olmasidir.

Mercedes merco = new Mercedes();
merco.Sunroof();
// sunroof metodu mercedes classi icinde override edildigi icin, Mercedes classi icindeki `Sunroof()` metodu calisacak.
// override edilmeseydi Tasit baseclass'i icindeki `Sunroof()` metodu calisacakti.
// ! Abstract classlarin nesne ornegi alinamaz. 

// Abstract classlar baska classlara yardimci olmak icin vardir. 