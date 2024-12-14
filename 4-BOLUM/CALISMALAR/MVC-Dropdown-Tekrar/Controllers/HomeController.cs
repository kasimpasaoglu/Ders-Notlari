using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Dropdown_Tekrar.Models;

namespace MVC_Dropdown_Tekrar.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        SelectorVM model = new SelectorVM();

        model.Classes = ModelCreate.ClassListCreator();

        return View(model);
    }

    [HttpPost]
    public IActionResult Index(SelectorVM model)
    {

        if (model.SelClassId != 0)
        {
            List<Class> classList = ModelCreate.ClassListCreator().Where(s => s.Id == model.SelClassId).ToList();
            model.Classes = classList;

            List<Lesson> lessonList = ModelCreate.LessonListCreator().Where(s => s.ClassId == model.SelClassId).ToList();

            model.Lessons = lessonList;

            if (model.SelLessonId != 0)
            {
                List<Lesson> lessonsList = ModelCreate.LessonListCreator().Where(s => s.Id == model.SelLessonId).ToList();
                model.Lessons = lessonsList;

                List<Topic> topicList = ModelCreate.TopicListCreator().Where(s => s.LessonId == model.SelLessonId).ToList();
                model.Topics = topicList;

                if (model.SelTopicId != 0)
                {
                    List<Topic> topicsList = ModelCreate.TopicListCreator().Where(s => s.Id == model.SelTopicId).ToList();
                    model.Topics = topicsList;

                    if (model.SelTopicId == 1)
                    {
                        return View("Sevgi", model);
                    }
                    else if (model.SelTopicId == 2)
                    {
                        return View("Saygi", model);
                    }
                }
            }
        }

        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
