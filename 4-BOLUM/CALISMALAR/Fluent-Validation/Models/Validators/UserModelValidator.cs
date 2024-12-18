using FluentValidation;


public class UserModelValidator : AbstractValidator<UserModel>
{
    public UserModelValidator()
    {
        RuleFor(user => user.Name)
            .NotEmpty().WithMessage("Name cannot be empty")
            .Length(2, 50).WithMessage("Name must be between 2 and 50 characters");

        RuleFor(user => user.Email)
            .NotEmpty().WithMessage("Email cannot be empty")
            .EmailAddress().WithMessage("Invalid email format");

        RuleFor(user => user.Age)
            .InclusiveBetween(18, 99).WithMessage("Age must be between 18 and 99");
    }
}
