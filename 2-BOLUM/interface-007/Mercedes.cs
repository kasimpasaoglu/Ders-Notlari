public class Mercedes : IAraba
{
    // asagidaki metodlar interface implementasyonu sonrasinda sinifa geldiler
    // interface'den gelen metodlarin imzasinda degisiklik yapilamaz.
    public void BakimYap()
    {
        throw new NotImplementedException();
    }

    public void Calis()
    {
        throw new NotImplementedException();
    }

    public void Dur()
    {
        throw new NotImplementedException();
    }
}

// inherit yapar gibi : IAraba eklendigikten sonra hata verdi, cunku interface ile zorunlu kilinan metodlar henuz yazilmamisti. 
// metodlari elle yazmak yerine vs code otomatik getirme secenegi sunuyor.