public class Ogrenci<T, K, M>
{
    public T TProp { get; set; }
    public K KProp { get; set; }
    public M MProp { get; set; }

    public M GenericMetod1(M value1, M value2)
    {
        return default(M);
    }
}
// T,K,M generic degerlerini sinif nesne ornegi olustururken verilecek.
// sinifa ait elemanlar bu generic tipler ile olusturulabilir.