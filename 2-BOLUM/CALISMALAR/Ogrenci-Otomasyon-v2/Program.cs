Main list = new();
while (true)
{
    int input = Main.Menu();

    if (input == 1)
    {
        Main.PrintStudents();
    }
    else if (input == 2)
    {
        Main.AddStudent();
    }
    else if (input == 3)
    {
        Main.DeleteStudent();
    }
    else if (input == 4)
    {
        Main.UpdateStudent();
    }
    else if (input == 5)
    {
        Main.SaveStudentsList();
    }
    else if (input == 6)
    {
        Main.LoadStudentsFromPath();
    }
    else if (input == 7)
    {

    }
    else if (input == 8)
    {

    }
    else if (input == 9)
    {

    }
}