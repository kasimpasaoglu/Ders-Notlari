public static class Messages
{
    public const string WELCOME_MESSAGE = "Welcome to the Student Automation application.";
    public const string MENU_1_LIST_STUDENT = "1 -> for  list students";
    public const string MENU_2_DELETE_STUDENT = "2 -> for delete a student";
    public const string MENU_3_ADD_STUDENT = "3 -> for add a student";
    public const string MENU_4_UPDATE_STUDENT = "4 -> for update a student";
    public const string MENU_5_EXIT = "5 -> for exit";
    public const string SUCCES_ADDED = "Succesfully added => ";
    public const string SUCCES_DELETED = "Succesfully deleted => ";
    public const string SUCCES_UPDATED = "Succesfully updated => ";
    public const string UPDATING = "Updating => ";
    public const string ERROR_WRONG_INPUT = "Incorrect input, please try again";
    public const string ERROR_WRONG_NAME = "Please enter a valid name without numbers or symbols.";
    public const string ERROR_EMPTY_COLLECTION = "The student collection is empty.";
    public const string ERROR_NOT_FOUND = "Student with the given ID was not found.";
    public const string PROMPT_ENTER_STUDENT_NAME = "Enter the student's name";
    public const string PROMPT_ENTER_STUDENT_ID = "Enter the student ID";
    public const string PROMPT_ENTER_ID_TO_DELETE = "Enter the ID of the student to delete";
    public const string PROMPT_ENTER_ID_TO_UPDATE = "Enter the ID of the student to update";
    public const string PROMPT_ENTER_NEW_NAME = "Enter the new name";
    public const string SEPERATOR = "-------------------------------";
    public static string GetStudentMessage(Student std)
    {
        return $"{std.Id,-3} || {std.Name,-20}";
    }
}
