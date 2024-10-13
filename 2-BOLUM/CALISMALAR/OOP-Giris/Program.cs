using System.Collections;

ArrayList students = new();
while (true)
{
    int menu = Func.MainMenu();
    if (menu == 1)
    {
        Func.NewStudent(students);
    }
    else if (menu == 2)
    {
        Func.PrintStudents(students);
    }
    else if (menu == 3)
    {
        break;
    }

}



