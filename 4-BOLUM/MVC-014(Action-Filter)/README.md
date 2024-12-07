# Action Filter

- Controller icindeki actionlarin calismadan once ve calistiktan sonra calismasini istedigimiz metodlara Action Filter denir.
- Genelde log tutmak vb, islemler icin kullanilir.
- Root dizinde Action Filter klasoru acip icine bir action filter olusturabiliriz

```C#
public class IndexActionFilter : IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
        // bu metod action cagrildiktan sonra calisir
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        // bu metod action cagrilmadan once calisir
    }
}
```

- :warning: Yazilan actionun `IActionFilter` interfaceinden implement edilmesi gerekmekdedir.

- Kullanabilmek icin [Program.cs](/Program.cs) dosyasina AddScope ekliyoruz

```C#
builder.Services.AddScoped<IndexActionFilter>();
```

> ORNEK; Kullanicinin girdigi e-mail adresinin dogru formatta olup olmadigini action'a gitmeden, filter icinde kontrol edelim

- [IndexActionFilter](/ActionFilter/IndexActionFilter.cs)
- [HomeControllerr.cs](/Controllers/HomeController.cs)

- Yetki kontrollerini Action Filter ile yapabiliriz.

- Odev: database yapalim, kullanicilar ve kullanicilarin girebilecegi yerler olsun. -> Veri tabanina git, kullanicin id'sine bak, o id'deki kullanicinin action yetkilerini cek. Kullanicinin girmeye caclistigi action'a yetkisi yoksa durdur.
