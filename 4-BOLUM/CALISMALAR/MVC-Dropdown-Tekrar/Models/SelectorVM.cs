public class SelectorVM
{
    public int SelClassId { get; set; }
    public int SelLessonId { get; set; }
    public int SelTopicId { get; set; }
    public List<Class> Classes { get; set; }
    public List<Lesson> Lessons { get; set; }
    public List<Topic> Topics { get; set; }
}

public class Class
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Lesson
{
    public int Id { get; set; }
    public int ClassId { get; set; }
    public string Name { get; set; }
}

public class Topic
{
    public int Id { get; set; }
    public int LessonId { get; set; }
    public string Name { get; set; }
}