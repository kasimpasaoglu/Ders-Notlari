using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class StudentActionFilter : IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
        // throw new NotImplementedException();
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        var jsonData = CookieHelper.GetCookie(context.HttpContext.Request, "LoginData");
        if (jsonData != null)
        {
            var userModel = CookieHelper.ToModel<VM.Login>(jsonData);

            if (!userModel.IsAdmin)
            {
                context.Result = new RedirectToActionResult("AdminRequired", "Student", null);
            }
        }
        else
        {
            context.Result = new RedirectToActionResult("LoginRequired", "Student", null);
        }
    }
}