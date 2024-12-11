using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class StudentShowActionFilter : IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
        // throw new NotImplementedException();
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        var jsonData = CookieHelper.GetCookie(context.HttpContext.Request, "LoginData");
        if (jsonData == null)
        {
            context.Result = new RedirectToActionResult("LoginRequired", "Student", null);
        }
    }
}