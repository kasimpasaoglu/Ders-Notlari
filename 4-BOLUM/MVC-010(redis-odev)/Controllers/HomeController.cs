using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_010_redis_odev_.Models;
using Newtonsoft.Json;

namespace MVC_010_redis_odev_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    private static int userCounter = 1;
    private static List<Car> CreateList()
    {
        List<Car> cars = new()
        {
            new Car { Id = 1, Name = "Toyota" },
            new Car { Id = 2, Name = "Honda" },
            new Car { Id = 3, Name = "Ford" },
            new Car { Id = 4, Name = "BMW" },
            new Car { Id = 5, Name = "Mercedes-Benz" },
            new Car { Id = 6, Name = "Audi" },
            new Car { Id = 7, Name = "Volkswagen" },
            new Car { Id = 8, Name = "Hyundai" },
            new Car { Id = 9, Name = "Kia" },
            new Car { Id = 10, Name = "Chevrolet" },
        };

        return cars;
    }

    public IActionResult Index()
    {
        Main model = new() { CarsList = CreateList() };
        return View(model);
    }

    [HttpPost]
    public IActionResult Index(Main returnedModel)
    {
        if (returnedModel.RequestedUserId == null) // eger requesteduserid gelmemisse, yeni veri girisi gelmistir. bu blok calissin
        {
            User newUser = returnedModel.User; // gelen modelinn icindeki useri al

            //  once id atamasini yap
            newUser.Id = userCounter; // id atamasini yap
            userCounter++; // id sayacini bir arttir


            // simdi secilen arabayi bulmak lazim
            var selCarId = returnedModel.SelectedCarId; // secilen arabanin id degeri
            var carList = CreateList(); // araba listesini al
            Car selectedCar = carList.FirstOrDefault(c => c.Id == selCarId); // araba listesi icinde `selCarId` degeri olan arabayi yakala.
            newUser.SelectedCar = selectedCar; // olusturulan userin SelectedCar propuna yakaladigimiz selectedCar'i koy.


            // jsona cevirip session(redis)'a bas
            var jsonUser = JsonConvert.SerializeObject(newUser); // yeni olusturulan user nesnesini json a cevir
            HttpContext.Session.SetString(newUser.Id.ToString(), jsonUser); // session'a at



            // yanit olustur
            ModelState.Clear(); // onceki modelden kalan her seyi temizleyip yeni model gonderecegim(inputlarin tekrar boslatilmasi icin)
            // sessiona veri basildiktan sonra, ekranda son kaydedilen kullanicin id'sini basmak icin, id yi Main modeline koyup geri yolluyorum
            // ayrica bir sonraki secim icin araba listesini de ayni modele koyuyorum.
            Main response = new()
            {
                LastSavedUserId = newUser.Id,
                CarsList = carList,
                User = null // user nesnesini temizle (inputlar temizlenmesi icin)
            };

            return View(response);
        }
        else // eger requestedId girisi geldiyse sorgu var bu blok calissin
        {
            // bu kosul icin geri donmesini istedigimiz modeli olusturalim
            Main response = new()
            {
                CarsList = CreateList() // modele arac listesini koy (tekrar veri girisi yapilmak istenirse...)
            };


            var reqId = returnedModel.RequestedUserId.ToString(); // hangi id'yi istiyor? 
            // (Getstring ile cagiracagimiz icin int degerini stringe cevir)

            string userJson = HttpContext.Session.GetString(reqId); // session'dan veriyi json formatinda aldik

            // eger userJson null gelirse, bu id de kullanici yok demektir
            if (userJson == null)
            {
                response.RequestedUserId = returnedModel.RequestedUserId; // istenen id yi modele geri koy
                response.IsIdFound = false; // bulunmazsa false yap 
                response.User = new User() { }; // null gitmesin diye bos bir user nesnesi koy modele
            }
            else // bulursa
            {
                User reqUser = JsonConvert.DeserializeObject<User>(userJson); // jsonu User tipine cevir
                response.User = reqUser; // gelen useri modelin icine koy
                response.IsIdFound = true; // bulunursa true yap
            }


            return View(response);
        }
    }



    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
