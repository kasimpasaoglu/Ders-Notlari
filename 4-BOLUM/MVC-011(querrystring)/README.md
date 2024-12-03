# QueryString

- Sayfalar arasi veri tasimak icin kullanilabilir
- QueryString key & value olacak sekilde belirlenir

```cshtml
<a href="/Home/QuerryString?name=Hasan&lastName=Ayaz" target="_blank" rel="noopener noreferrer"></a>
```

- Home/ Querry string denen controller'a name ve lastname olan iki adet parametre gonderildi.
- Querry string session gibi gizli olarak gonderilmez, browser'in adres cubugunda gorunur,
- Bu sebeple sifre gibi gizli veriler bu yontemle gonderilmemelidir.

- Controller da nasil alacagiz?
  - Farkli yontemleri vardir.

```C#
public IActionResult QueryString(string name, string lastname)
{
    return View();
}
```

> actionun paramatrelerine key degerleri ile degisken tanimlanirsa, C# otomatik mapler.

```C#
public IActionResult QueryString(QueryStringModel model)
{
    return View();
}
```

> Actiona gelecek olan querrye uygun bir model, parametre olarak verilirse yine otomatik olarak mapler ve action icinden erisilebilir.

```C#
public IActionResult QueryString()
{
    var result = HttpContext.Request.QueryString;
    return View();
}
```

> `HttpContext.Request.QueryString` ile dogrudan HttpContext icinden erisilebilir.

- Son yontem ise dependency injection yontemi bir sonraki konu basligimiz olacak.
