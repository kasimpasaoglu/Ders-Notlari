public class Messages
{
    public const string Menu1PrintStudents = "1 -> List Students";
    public const string Menu2AddStudent = "2 -> Add Student";
    public const string Menu3DeleteStudent = "3 -> Delete Student";
    public const string Menu4UpdateStudent = "4 -> Update Student";
    public const string Menu5SaveStudents = "5 -> Save to File";
    public const string Menu6GetStudents = "6 -> Load from File";
    public const string Menu7FindStudent = "7 -> Search Student by Name";
    public const string Menu8SortStudents = "8 -> Sort by Grade Average";
    public const string Menu9Exit = "9 -> Exit";
    public const string SuccessLoadedFromFile = "Students successfully loaded from file.";
    public const string SuccessSortedByGrade = "Students sorted by grade average.";
    public const string SuccessAdded = "Succesfully added => ";
    public const string SuccessDeleted = "Succesfully deleted => ";
    public const string SuccessFound = "Student found => ";
    public const string SuccessUpdated = "Succesfully updated => ";
    public const string ErrorFileNotFound = "File not found.";
    public const string ErrorCollectionEmpty = "The student list is empty.";
    public const string ErrorWrongInput = "Wrong input, please try again.";
    public const string ErrorCannotFindId = "Can not find student with given ID. Please try again.";
    public const string ErrorCannotFindName = "Can not find student with given Name & Surname. Please try again.";
    public const string PromptMakeChoice = "Please enter your choice:";
    public const string PromptEnterStudentName = "Enter the student's name & surname:";
    public const string PromptEnterStudentGrade = "Enter the student's grade :";
    public const string PromptEnterId = "Enter the ID of the student :";
    public const string PromtSort1ByGrade = "1 -> Sory By Grade";
    public const string PromtSort2ByName = "2 -> Add Student";
    public const string Separator = "----------------------------------------------";
    public const string JsonPath = "data/students.json";

    public static string SuccessLoadToFile()
    {
        return $"Students successfully loaded from file -> {JsonPath}";
    }
    public static string SuccessSavedToFile()
    {
        return $"Students successfully saved to file -> {JsonPath}";
    }
    public static string GetTemplate()
    {
        return $"{"ID",-3} || {"NAME",-20} || {"GRADE",-5}";
    }

    public static string GetStudentMessage(Student std)
    {
        return $"{std.Id,-3} || {std.Name,-20} || {std.AverageGrade,-5}";
    }
}
