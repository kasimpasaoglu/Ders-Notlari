using AutoMapper;
using Database;
using DMO;
public class StudentRepo : IStudentRepo
{
    private Db _context;
    private IMapper _mapper;
    public StudentRepo(IMapper mapper, Db context)
    {
        _context = context;
        _mapper = mapper;
    }
    public DTO.Student AddStudent(DTO.Student model)
    {
        var dmoModel = _mapper.Map<Student>(model);
        _context.Students.Add(dmoModel);
        int result = _context.SaveChanges();
        if (result > 0)
        {
            model.ErrorMessage = $"Student {model.Name} {model.LastName} added successfully.";
        }
        else
        {
            model.Id = -1; // ekleme islemi basarisiz olursa id degerini -1 olarak isaretleyip oyle gonderiyoruz.
            model.ErrorMessage = $"Error occured when adding student {model.Name} {model.LastName}";
        }
        return model;
    }
    public DTO.Student RemoveStudent(DTO.Student model)
    {
        var dmoModel = _mapper.Map<Student>(model);
        dmoModel = _context.Students.FirstOrDefault(s => s.Name == dmoModel.Name && s.LastName == dmoModel.LastName);
        if (dmoModel != null)
        {
            _context.Students.Remove(dmoModel);
            int result = _context.SaveChanges();
            if (result > 0)
            {
                model = null;
                model = _mapper.Map<DTO.Student>(dmoModel);
                model.ErrorMessage = $"Student {model.Name} {model.LastName} removed succesfully.";
                return model;
            }
            else
            {
                model.ErrorMessage = $"An error occured when deleting student {model.Name} {model.LastName}.";
                return model;
            }
        }
        else
        {
            model.ErrorMessage = $"Student {model.Name} {model.LastName} not found.";
            return model;
        }

    }
    public List<DTO.Student> GetAll()
    {
        List<Student> dmoList = _context.Students.ToList();
        List<DTO.Student> dtoList = new();
        foreach (var item in dmoList)
        {
            dtoList.Add(_mapper.Map<DTO.Student>(item));
        }
        return dtoList;
    }
}

public interface IStudentRepo
{
    public DTO.Student AddStudent(DTO.Student model);
    public DTO.Student RemoveStudent(DTO.Student model);
    public List<DTO.Student> GetAll();
}