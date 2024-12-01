# Cookie

Web sayfalarinin kullaniciyi tanimasi icin, kisinin bilgisayarina biraktigi bir text dosyadir.

1. Program cs dosyasinda `app.UseCookiePolicy()` komutu ile cookie kullanimina izin verildi.
2. Controller'da cookie olusturmak icin `Response.Cookies.Append()` metodunu kullanacagiz, ancak oncesinde, bu metodun parametrelerinden biri olan options, yani konfigrasyonu hazilamak gerek

```C#
    var emailOptions = new CookieOptions
    {
        Expires = DateTime.Now.AddDays(1), // bir gun sonra expires olsun
        HttpOnly = true,
        Secure = true,
        SameSite = SameSiteMode.Strict // CRFS saldirilana karsi koruma 
    };
    var passwordOptions = new CookieOptions
    {
        Expires = DateTime.Now.AddDays(1), // bir gun sonra expires olsun
        HttpOnly = true,
        Secure = true,
        SameSite = SameSiteMode.Strict // CRFS saldirilana karsi koruma 
    };                
```

3. Simdi e-mail ve sifre bilgisini cookielere yazalim

```C#
    Response.Cookies.Append("Email", shaEmail, emailOptions);
    Response.Cookies.Append("Password", shaPasword, passwordOptions);
```

4. Baska bir controllerda ve ya baska bir yerde bu cookie yi okumak icin

```C#
    var email = Request.Cookies["Email"];
    var password = Request.Cookies["Password"];
```

## Ozel verileri encrypt etme yontemi

```C#
public string CreateSHA512(string input)
    {
        SHA512 sha512 = SHA512.Create();
        byte[] inputByte = Encoding.UTF8.GetBytes(input);
        byte[] hashByte = sha512.ComputeHash(inputByte);
        StringBuilder builder = new StringBuilder();
        foreach (byte b in hashByte)
        {
            builder.Append(b.ToString("x2"));
        }

        return builder.ToString();
    }
```

Boyle bir metod yazip metoda parametre olarak verilen string degeri SHA512 ile sifreleyebiliriz.

## Sayfa icindeki inputlari dogru maplemek

Olusturulan inputlara model mapingi olmasi icin name isimli attribute un verilmesi lazim
Eger name attribute verilmezse mapleme yapmaz,

Name mapping icin farkli yontemler var

1. Name attribute'une elle "Emal Yazmak"
2. Degeri modelin icindeki propun adindan almasini istiyorsaniz `asp-for="@Model.Email"` seklinde attribute ile yazilabilir. bu komut modelin icindeki prop adini inputa name olarak ekleyecektir.
3. Yontem jquery ve ya js ile post yapilip, veriler orda maplenembilri
4. Daha once gordugumuz @Html.TextBoxFor ile olusturulabilir.
