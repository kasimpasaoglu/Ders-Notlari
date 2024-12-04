using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_013_EntityFramework.Models;

namespace MVC_013_EntityFramework.Controllers;

public class HomeController : Controller
{
    private BooksDBContext _context;

    public HomeController(BooksDBContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        _context.Add(new Book { Name = "Book1", Price = 150, Stock = 10 });
        _context.Add(new Book { Name = "Book2", Price = 160, Stock = 9 });
        _context.Add(new Book { Name = "Book3", Price = 110, Stock = 18 });
        _context.Add(new Book { Name = "Book4", Price = 90, Stock = 8 });
        _context.Add(new Book { Name = "Book5", Price = 125, Stock = 7 });
        _context.Add(new Book { Name = "Book6", Price = 112, Stock = 1 });
        _context.Add(new Book { Name = "Book7", Price = 118, Stock = 3 });
        _context.Add(new Book { Name = "Book8", Price = 124, Stock = 7 });
        _context.Add(new Book { Name = "Book9", Price = 138, Stock = 15 });
        _context.Add(new Book { Name = "Book10", Price = 174, Stock = 12 });

        _context.SaveChanges();
        return View();
    }

}
