using AutoMapper;
using DTO;

public class StudentService : IStudentService
{
    private IStudentRepo _repo;
    public StudentService(IStudentRepo repo)
    {
        _repo = repo;

    }
    public Student AddStudent(Student model)
    {
        var answer = _repo.AddStudent(model);
        if (model.Id < 0) // id 0 dan kucuk deger isaretlenmisse ekleme islemi basarisiz.
        {
            model.IsAdded = false;
        }
        else
        {
            model.IsAdded = true;
        }
        return answer;
    }

    public Student RemoveStudent(Student model)
    {
        var answer = _repo.RemoveStudent(model);
        if (answer.Id == 0)
        {
            answer.IsRemoved = false;
        }
        else
        {
            answer.IsRemoved = true;
        }
        return answer;
    }

    public List<Student> GetAll()
    {
        return _repo.GetAll();
    }
}

public interface IStudentService
{
    public Student AddStudent(Student model);
    public Student RemoveStudent(Student model);
    public List<Student> GetAll();
}