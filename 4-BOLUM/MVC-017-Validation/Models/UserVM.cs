using System.ComponentModel.DataAnnotations;

public class UserVM
{
    [MinLength(3, ErrorMessage = "Giris 2 karakterden daha uzun olmalidir")]
    [Required(ErrorMessage = "Ad Alani Bos Biraklamaz")] // name alani bos girlilememesini saglayacak
    public string Name { get; set; }

    [MaxLength(20, ErrorMessage = " E-Mail en fazla 20 karakter olabilir")]
    [Required(ErrorMessage = "E-Mail alani bos olamaz")]
    [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "E-Mail adres uygun degil")]
    public string Email { get; set; }

    [Range(10, 70, ErrorMessage = "Yas 10-70 arasinda olmalidir")]
    public int Age { get; set; }


    [Required(ErrorMessage = "Sifre Alani bos birakilamaz")]
    public string Password { get; set; }
    [Compare("Password", ErrorMessage = "Sifreler ayni degil")]
    public string ConfirmPassword { get; set; }
}