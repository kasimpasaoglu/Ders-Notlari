using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VM;

public class StudentController : Controller
{
    private IMapper _mapper;
    private IStudentService _service;
    public StudentController(IMapper mapper, IStudentService service)
    {
        _mapper = mapper;
        _service = service;
    }

    [ServiceFilter(typeof(StudentActionFilter))]
    public IActionResult Edit()
    {
        return View(new Student() { BirthDate = DateOnly.Parse("01.01.2000") });
    }
    [HttpPost]
    public IActionResult Add(Student model)
    {
        var dtoAnswer = _service.AddStudent(_mapper.Map<DTO.Student>(model)); // service katmaninda islem yap yaniti al,
        model = _mapper.Map<Student>(dtoAnswer); // yaniti modele donustur
        return View("Edit", model); // edit isimli viewa modeli yolla
    }
    [HttpPost]
    public IActionResult Remove(Student model)
    {

        var dtoAnswer = _service.RemoveStudent(_mapper.Map<DTO.Student>(model)); // modeli DTOya cevirip service yolla
        var answer = _mapper.Map<Student>(dtoAnswer); // yaniti VM e cevir.

        return View("Edit", answer); // ekrana yolla
    }
    public IActionResult LoginRequired()
    {
        return View();
    }

    public IActionResult AdminRequired()
    {
        return View();
    }

    [ServiceFilter(typeof(StudentShowActionFilter))]
    public IActionResult Show()
    {
        var dtoList = _service.GetAll();
        List<Student> list = new();
        foreach (var item in dtoList)
        {
            list.Add(_mapper.Map<Student>(item));
        }

        return View(list);
    }
}