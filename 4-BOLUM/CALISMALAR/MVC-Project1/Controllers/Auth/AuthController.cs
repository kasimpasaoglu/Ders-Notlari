using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VM;

public class AuthController : Controller
{
    private IAuthService _service;
    private IMapper _mapper;
    public AuthController(IAuthService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    public IActionResult Login()
    {
        var loginDataJson = CookieHelper.GetCookie(Request, "LoginData");
        if (!string.IsNullOrEmpty(loginDataJson))
        {
            var loginData = CookieHelper.ToModel<Login>(loginDataJson);
            return View(loginData);
        }
        return View(new Login() { UserName = "index" });

    }

    [HttpPost]
    public IActionResult Login(Login model)
    {
        var dtoModel = _mapper.Map<DTO.Login>(model); //dto ya cevir
        var resultDto = _service.LoginUser(dtoModel); // service yolla
        var resultVm = _mapper.Map<Login>(resultDto); // yaniti vm e cevir
        if (resultVm.RememberMe) // kullanici rememberme sectiyse cookie kalici olmali
        {
            var cookieOptions = new CookieOptions // cookie ayarlarini kalici hale getirmek icin...
            {
                Expires = DateTime.Now.AddYears(1), // en az 1 yil kalici olacak
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict
            };
            CookieHelper.SetCookie(Response, "LoginData", CookieHelper.ToJson(resultVm), cookieOptions);
        }
        else // eger rememberMe secilmediyse
        {
            CookieHelper.SetCookie(Response, "LoginData", CookieHelper.ToJson(resultVm)); // cookie'yi default ayarlarla kaydettik(oturum bazli kalacak).
        }
        return View(resultVm); // modeli viewa yolla
    }
    [HttpPost]
    public IActionResult Logout(Login model)
    { // logout islemi
        model.IsLoggedIn = false; // modelde iki alani degistir
        model.RememberMe = false;
        model.UserName = "index";
        CookieHelper.RemoveCokie(Response, "LoginData"); // eski cookieyi kaldir
        return View("Login", model); // login ekranina yolla
    }
    public IActionResult SignIn()
    {
        return View(new Login());
    }


    [HttpPost]
    public IActionResult SignIn(Login model)
    {
        var dtoModel = _mapper.Map<DTO.Login>(model); // dtoya cevir
        var dtoUserAnswer = _service.SaveUser(dtoModel); // service'a yolla
        var vmUserAnswer = _mapper.Map<VM.Login>(dtoUserAnswer); // yaniti vm'e cevir
        return View(vmUserAnswer); // viewa yolla
    }
}