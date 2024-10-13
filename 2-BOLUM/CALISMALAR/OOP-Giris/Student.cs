using System.Collections;

public class Student
{
    public int idNo;
    public string name;
    public string lastName;
    public int age;
    public double avarageGrade;
    public Student(string x, string y, int z, double a)
    {
        idNo = new Random().Next(1000, 2000);
        name = x;
        lastName = y;
        age = z;
        avarageGrade = a;
    }
}
public class Func
{

    public static int MainMenu()
    {
        Console.WriteLine("Lutfen Bir Secim Yapiniz");
        Console.WriteLine("1. Yeni Ogrenci Kaydi");
        Console.WriteLine("2. Kayitli Ogrencileri Goruntule");
        Console.WriteLine("3. Cikis Yap");
        int input;
        while (!int.TryParse(Console.ReadLine().Trim(), out input) || input > 3 || input < 1)
        {
            Console.WriteLine("Lutfen Gecerli Bir Secim Yapiniz");
        }
        return input;
    }
    public static void NewStudent(ArrayList list)
    {
        Console.WriteLine("Isim :");
        var name = Console.ReadLine().Trim();
        Console.WriteLine("Soyisim :");
        var lastName = Console.ReadLine().Trim();
        Console.WriteLine("Yas :");
        var age = int.Parse(Console.ReadLine().Trim());
        Console.WriteLine("Not Ortalamasi");
        var avarageGrade = double.Parse(Console.ReadLine().Trim());

        list.Add(new Student(name, lastName, age, avarageGrade));
        Console.WriteLine("-Kayit Tamamlandi-");
        Console.WriteLine($"No: {((Student)list[0]).idNo} =>  {name} {lastName} || Yas = {age} || Ortalama = {avarageGrade}");

    }

    public static void PrintStudents(ArrayList list)
    {
        foreach (Object student in list)
        {
            Console.WriteLine($"No: {((Student)student).idNo} => {((Student)student).name} {((Student)student).lastName} || Yas: {((Student)student).age} || Not Ortalmasi : {((Student)student).avarageGrade}");
        }
    }
}