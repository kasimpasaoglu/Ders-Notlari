using AutoMapper;
using DTO;
using Microsoft.AspNetCore.Mvc;
using VM;

namespace MVC_015_Rest_client_.Controllers;

public class HomeController : Controller
{
    public IWebApiService _webApiService;
    public IMapper _mapper;

    public HomeController(IWebApiService webApiService, IMapper mapper)
    {
        _webApiService = webApiService;
        _mapper = mapper;
    }

    public IActionResult Index()
    {
        RickAndMortyDTO result = _webApiService.GetAll(); // service katmanindaki GetAll metodundan gelen veri DTO olarak burda,
        RickAndMortyVM model = _mapper.Map<RickAndMortyVM>(result); // result isimli DTO'yu al, model isimli VM'e maple.

        return View(model);
    }
}
