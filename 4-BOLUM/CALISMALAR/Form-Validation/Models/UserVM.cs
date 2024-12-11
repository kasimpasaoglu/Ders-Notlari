using System.ComponentModel.DataAnnotations;

public class UserVM
{
    [MinLength(3, ErrorMessage = "Name must be minimum 3 chars lenght ")]
    [Required(ErrorMessage = "This field cannot be empty")]
    public string Name { get; set; }

    [MinLength(3, ErrorMessage = "Name must be minimum 3 chars lenght ")]
    [Required(ErrorMessage = "This field cannot be empty")]
    public string LastName { get; set; }

    [MaxLength(30, ErrorMessage = "E-Mail must be maximum 30 chars lenght")]
    [Required(ErrorMessage = "This field cannot be empty")]
    [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Incorrect format for E-Mail")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Password cannot be empty")]
    [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$", ErrorMessage = "Password does not comply with the rules")]
    public string Password { get; set; }

    [Compare("Password", ErrorMessage = "Passwords does not match")]
    public string RePassword { get; set; }
}