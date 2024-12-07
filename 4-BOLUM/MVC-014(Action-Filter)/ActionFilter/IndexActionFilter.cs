using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class IndexActionFilter : IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
        // bu metod action cagrildiktan sonra calisir
        // throw new NotImplementedException();
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        // Bu metod action cagrilmadan once calisir.
        // Model olarak gelen mail alaninin uygun olup olmadigini kontrol edelim
        // Bu kontrolu yapmak icin `Regex` denen bir teknoloji kullanacagiz.

        var modelResult = context.ActionArguments.Values.FirstOrDefault();
        if (modelResult == null)
        {
            // ActionResult actiondan once calisacagi icin, geriye result donemmiz gerekmektedir.
            // context.Result'a deger validasyonundan geriye olumsuuz bir donuz varsa geriye BadRequestObjectResult verilebilir.
            context.Result = new BadRequestObjectResult("Model Yok!");
        }

        var indexViewModel = (IndexViewModel)context.ActionArguments["model"];
        if (indexViewModel != null) // indexViewModel null degilse
        {
            if (indexViewModel.Email != null) // model icindeki Email alani null degilse
            {
                // Burda regex ile mail adresinin dogrulugunu kontrol edelim
                var regex = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$"); // regex kurali tanimlandi
                bool isOk = regex.IsMatch(indexViewModel.Email);

                if (!isOk)
                {
                    /*
                    context.Result = new BadRequestObjectResult("E-Mail Uygun Degil");
                    return; 
                    */
                    // mail uygun degilse, controller'a hic gitmeden burda return vererek cikiyoruz

                    // yukardaki kullanim, viewdan bagimsiz bir sekilde sayfada bir metin cikarir. 
                    // eger akisi bozmayip post actiona bir mesaj gondermek istiyorsak asagidaki gibi yapabiliriz
                    context.HttpContext.Items["FilterExceptionMessage"] = "E Mail Uygun Degildir";
                }
            }
        }
    }
}