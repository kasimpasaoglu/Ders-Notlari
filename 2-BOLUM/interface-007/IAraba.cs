// interface tanimi
public interface IAraba
{
    // interface icerisinde metod yazilacak ise sadece imzasi yazilir. Metod govdesi bu interface'i kullanan(sablon olarak alan) siniflar icin yazilir, her govde birbirinden farkli olabilir.
    // interface icerisinde metodun geri donus tipi aldigi parametreler vardir.
    // erisim belirtec yazilmaz, cunku erisim belirtec bu interfacein uygulanacagi sinif icerisinde belirlenir.
    void Calis();
    void Dur();
    void BakimYap();
}