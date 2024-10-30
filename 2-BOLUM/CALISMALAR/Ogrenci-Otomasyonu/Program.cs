while (true)
{
    int input = StudentHelper.Menu();
    if (input == 1)
    {
        StudentHelper.PrintStudents();
    }
    else if (input == 2)
    {
        StudentHelper.DeleteStudent();
    }
    else if (input == 3)
    {
        StudentHelper.AddStudent();
    }
    else if (input == 4)
    {
        StudentHelper.UpdateStudent();
    }
    else if (StudentHelper.IsExiting())
    {
        break;
    }
}