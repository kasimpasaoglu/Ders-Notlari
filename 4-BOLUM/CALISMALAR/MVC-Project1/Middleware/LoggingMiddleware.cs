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
        var body = "";

        if (context.Request.Body != null)
        {
            var reader = new StreamReader(context.Request.Body);
            body = reader.ReadToEndAsync().Result;
        }

        _next(context).Wait();

        LogModel model = new()
        {
            Date = DateTime.Now.ToString(),
            Path = context.Request.Path,
            Body = body,
        };
        MongoDbClient.AddLog(model);

        //

        stopwatch.Stop();
    }
}