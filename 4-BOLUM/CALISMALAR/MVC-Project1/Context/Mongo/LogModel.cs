using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

public class LogModel
{
    public string Date { get; set; }
    public string Path { get; set; }
    public string Body { get; set; }
}