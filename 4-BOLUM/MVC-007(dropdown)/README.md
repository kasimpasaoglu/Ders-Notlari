# Dropdown

Kullaniciya acilir bir listeden bir oge sectirmek icin HTML'de `select` etiketi icinde liste ogelerini belirlemek icin `option` elementleri ekliyorduk.

- Daha profesyonel ve dinamik bir liste olusturmak icin, liste icin bir model olusturuyoruz

```C#
public class DropdownViewModel
{
    public int SelectedCarId { get; set; }
    public List<Car> Cars { get; set; }
}

public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
}
```

- Ana modelimiz `DropdownViewModel` olacak, ve kullanici araba listesinde bir secim yaptigi zaman model controller'a geri geldiginde `SelectedCarId` propunda bir deger tasiyarak gelmesini istiyoruz.
- Biz controllerda bu id numarasiyla, araba listesi icinde arama yapipi kullanicinin hangi arabayi sectigini anlayabilecegiz.

```C#
public IActionResult Index()
    {
        // dropdowna yuklemek icin modeli hazirlayalim
        var cars = new List<Car>
        {
            new Car(){Id = 1, Name="Audi"},
            new Car(){Id = 2, Name="BMW"},
            new Car(){Id = 3, Name="Mercedes"},
            new Car(){Id = 4, Name="Peugeot"},
            new Car(){Id = 5, Name="Toyota"},
            new Car(){Id = 6, Name="Fiat"},
            new Car(){Id = 7, Name="Skoda"},
        };
        return View(new DropdownViewModel() { Cars = cars });
    }

[HttpPost]
public IActionResult Index(DropdownViewModel model)
    {
        // dropdown dan secilen deger secildikten sonra submite'e basildiginda, view model action'a gelir
        // ve icinde dropdowndan yapilan secime ait id degerini tasir.
        // yani asagidaki sekilde model icinden kullanicin sectigi id yi yakalayabilmeliyiz.
        var selectedCarId = model.SelectedCarId;
        
        return View();
    }
```

- View tarafinda daha once bahsettigimiz `Razor Elements` yardimi ile listeyi bu sekilde olustuyoruz.

```cshtml
@model DropdownViewModel

<form action="/Home/Index" method="post">
    @Html.DropDownListFor(
            // kullanicinin sectigi degere ait olan Id yi yakalamak icin
            s => s.SelectedCarId, 
            // secim yapilacak listeyi olusturma
            new SelectList(Model.Cars, "Id", "Name"), 
            "Lutfen Araci Seciniz") // ilk acilinca listede bu yazacak
    <input type="submit" value="Secimi Gonder">
</form>
```
