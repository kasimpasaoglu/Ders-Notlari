// 3 Cesit model olusturrlabilir
// 1. ViewModel
// 2. DTO Model
// 3. DMO (Data Model Object)

// asagidaki SaveUser Modeli bir viewmodeldir
public class SaveUserViewModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public bool IsOk { get; set; }
}