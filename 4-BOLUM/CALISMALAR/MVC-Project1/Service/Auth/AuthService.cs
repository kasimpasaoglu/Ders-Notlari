using AutoMapper;
using Azure;
using DTO;
// service katmaninda is mantigi yapilacak bu yuzden mappin islemleri burda yapilmayacak, buraya modeller her zaman dto olarak gelip dto olarak cikacak.
public class AuthService : IAuthService
{
    private IAuthRepo _repo;
    public AuthService(IAuthRepo repo)
    {
        _repo = repo;
    }

    public Login LoginUser(DTO.Login dtoUser)
    {
        var answer = _repo.GetLogin(dtoUser); // gelen user'i repoya yolladik, sorgulanip geri gelecek

        if (answer.Id == 0) // gelen yanit id degeri 0 ise bir kullanici bulunmamis demektir
        {
            dtoUser.IsLoggedIn = false; // default olarak false, ama emin olmak icin tekrar bastik
            dtoUser.UserName = ""; // username ve sifre alanlarini bosaltiyoruz
            dtoUser.Password = "";
            return dtoUser; // useri geri gonderdik
        }
        else // kullanici bulundu, giris basarili
        {
            if (dtoUser.RememberMe)
            {
                answer.RememberMe = true; // Repo'dan gelen yanitta bu alan olmadigi icin bunu tekrar answer'a ekledik.
            }
            answer.IsLoggedIn = true; // giris basarili, true isaretledik
        }
        return answer;
    }

    public Login SaveUser(DTO.Login dtoUser)
    {
        if (_repo.SetLogin(dtoUser))
        {
            dtoUser.IsSaved = true;
        }
        else
        {
            dtoUser.IsSaved = false;
        }
        return dtoUser;
    }
}

public interface IAuthService
{
    public Login LoginUser(DTO.Login dtoUser);
    public Login SaveUser(DTO.Login dtoUser);
}