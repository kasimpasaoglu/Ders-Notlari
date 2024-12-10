using System.Diagnostics;

public class LoggingMiddleware
{
    private readonly RequestDelegate _next;
    public LoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var stopwatch = Stopwatch.StartNew();

        string body = "";

        if (context.Request != null)
        {
            if (context.Request.Body != null)
            {
                // context icindeki Request icindeki Body direk erisilebilir degil.
                // Body byte cinsinden duran bir tip, byte cinsinden veriyi stream ile okumak gerekir.


                // StreamReader modeli ile body'i okuruz
                var reader = new StreamReader(context.Request.Body);
                // byte veri tipinde son satira kadar okuma yapmak gerekir. 
                //Yukardaki StreamReader'in okumasini yapip, icindeki Results bolumunde sayfadaki inputlarda yazilan veriyi yakaladik, ve body isimli degiskene atadik.
                body = reader.ReadToEndAsync().Result;
            }
        }

        _next(context).Wait();

        LogModel model = new LogModel()
        {
            Date = DateTime.Now.ToLongTimeString(),
            Path = context.Request.Path,
            Body = body
        };
        new MongoDbClient().AddLog(model);

        stopwatch.Stop();
    }
}