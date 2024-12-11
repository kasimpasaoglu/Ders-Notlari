
using Newtonsoft.Json;

public class CookieHelper
{
    private static readonly CookieOptions DefaultCookieOptions = new CookieOptions
    {
        HttpOnly = true,
        Secure = true,
        SameSite = SameSiteMode.Strict
    };

    /// <summary>
    /// Modeli JSON string'e cevirir.
    /// </summary>
    public static string ToJson<T>(T modelData)
    {
        return JsonConvert.SerializeObject(modelData);
    }
    /// <summary>
    /// JSON string'i Modele cevirir.
    /// </summary>
    public static T ToModel<T>(string jsonData)
    {
        return JsonConvert.DeserializeObject<T>(jsonData);
    }

    /// <summary>
    /// Cookie'ye veri yazar.
    /// </summary>
    public static void SetCookie(HttpResponse response, string key, string value, CookieOptions options = null)
    {
        response.Cookies.Append(key, value, options ?? DefaultCookieOptions);
    }

    /// <summary>
    /// Cookie'den veri okur.
    /// </summary>
    public static string GetCookie(HttpRequest request, string key)
    {
        return request.Cookies[key];
    }
    public static void RemoveCokie(HttpResponse response, string key)
    {
        response.Cookies.Delete(key);
    }
}
