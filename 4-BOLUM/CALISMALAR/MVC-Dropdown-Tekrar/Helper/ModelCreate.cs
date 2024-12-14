public static class ModelCreate
{
    public static List<Class> ClassListCreator()
    {
        List<Class> list = new()
        {
            new Class(){Id = 1, Name="1.Sinif"},
            new Class(){Id = 2, Name="2.Sinif"},
            new Class(){Id = 3, Name="3.Sinif"},
        };
        return list;
    }

    public static List<Lesson> LessonListCreator()
    {
        return new List<Lesson>()
        {
            new Lesson(){Id =1, ClassId= 1, Name="Hayat Bilgisi"},
            new Lesson(){Id =2, ClassId= 1, Name="Turkce"},

            new Lesson(){Id =3, ClassId= 2, Name="Matematik"},
            new Lesson(){Id =4, ClassId= 2, Name="Muzik"},

            new Lesson(){Id =5, ClassId= 3, Name="Fizik"},
            new Lesson(){Id =6, ClassId= 3, Name="Kimya"}
        };

    }

    public static List<Topic> TopicListCreator()
    {
        List<Topic> list = new()
        {
            new Topic(){Id=1, LessonId=1, Name="Sevgi"},
            new Topic(){Id=2, LessonId=1, Name="Saygi"},

            new Topic(){Id=3, LessonId=2, Name="Zamir"},
            new Topic(){Id=4, LessonId=2, Name="Fiil"},

            new Topic(){Id=5, LessonId=3, Name="Toplama"},
            new Topic(){Id=6, LessonId=3, Name="Cikarma"},

            new Topic(){Id=7, LessonId=4, Name="Blok Flut"},

            new Topic(){Id=8, LessonId=5, Name="Hareket"},
            new Topic(){Id=9, LessonId=5, Name="Kuvvet"},

            new Topic(){Id=10, LessonId=6, Name="Hal Degisimleri"},
        };

        return list;
    }
}