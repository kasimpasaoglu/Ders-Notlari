using AutoMapper;
using Database;
using DMO;
// repo katmani sadece sunucu ile baglanti kuracak, gelen yaniti service katmanina iletecek. DTO olarak alip DTO olarak geri verecek, DMO donusumunu kendi icinde yapacak.
public class AuthRepo : IAuthRepo
{
    private Db _context;
    private IMapper _mapper;
    public AuthRepo(Db context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public DTO.Login GetLogin(DTO.Login dtoModel)
    {
        var dmoModel = _mapper.Map<Login>(dtoModel); // sorgulama yapmak icin modeli dmo ya cevirdik.
        Login user = _context.Logins.FirstOrDefault(x => x.UserName == dmoModel.UserName && x.Password == dmoModel.Password); // kullanici adi ve sifre eslesen satiri yakala
        if (user == null) // bos gelirse bulunmadi demektir
        {
            return dtoModel; // ayni modeli geri yolladik
        }
        else // null degilse kullanici giris yapabilir
        {
            return _mapper.Map<DTO.Login>(user); // yaniti dto ya cevir ve yolla
        }
    }

    public bool SetLogin(DTO.Login dtoModel)
    {
        var dmoModel = _mapper.Map<DMO.Login>(dtoModel);
        bool isNameExists = _context.Logins.Select(x => x.UserName).Contains(dmoModel.UserName);
        if (!isNameExists)
        {
            _context.Logins.Add(dmoModel);
            int result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}

public interface IAuthRepo
{
    public DTO.Login GetLogin(DTO.Login dtoModel);
    public bool SetLogin(DTO.Login dtoModel);
}