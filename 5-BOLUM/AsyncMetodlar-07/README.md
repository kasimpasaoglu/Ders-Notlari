# Asenkron Metodlar

- Buyuk veri tabanlarinda buyuk sonuclari olan sorgular atildiginda, bu verinin gelmesi uzun surecektir.
  - Ornegin yapilan sorgunun yanitlanma suresi 1 dk olsun
  - bu istek surerken baska bir kullanici 10sn de gelecek bir veri cektigini varsayalim
  - Her ne kadar ikinci kullanici 10 sn de gelecek veri cekiyor olsa da islemci ilk istegi yapmaya calistigi icin ikinci kullanici bekleyecektir.
  - Eger sorgu yapilan kanali bir otoyola benzetirsek, ikinci sorgunun ilk sorguyu beklememesini saglamak icin, yolda yeni bir serit acariz.
    - Bu sekilde olusturulan her bir serite `thread` denir.

- Async metodlar her zaman `Task<T>` donerler. `T` dedigimiz kisim generictir, ve genelde doneceginiz tipi temsil eder.
- `await` ifadesi bir metodun tamamlanmasini beklerken mevcut thread'i serbest birakir. Yani baska islemlerin yapilmasina oncelik tanir.
- Asenkron kod ozellikle yuksek **IO(input output)** islemleri iceren senaryolarda performansi ciddi arttirir.
- Agir olan sorguya `async` verilerek diger islemleri ve sorgulari tikanmamasi saglanir.

---

```C#
public async Task<List<Book>> GetBookAsync()
{
    await Task.Delay(5000); // islemi bilincli olarak agirlastirmak icin
    return Books;
}
```

- Controllerda Bu metodu kullanalim

```C#
public async Task<IActionResult> Index()
{
    var books = await repository.GetBookAsync(); // 5s delay verdigimiz icin yanit 5 sanyiye surecek, bu sure icinde threadi serbest birakmak icin await ekledik
    return View(books);
}
```
