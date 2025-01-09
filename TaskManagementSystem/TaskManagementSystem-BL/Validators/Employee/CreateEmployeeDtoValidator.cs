using FluentValidation;
using TaskManagementSystem_BL.DTOs.EmployeeDtos;

namespace TaskManagementSystem_BL.Validators.Employee
{
    public class CreateEmployeeDtoValidator : AbstractValidator<CreateEmployeeDto>
    {
        public CreateEmployeeDtoValidator()
        {
            RuleFor(x=>x.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Name cannot be empty")
                .MaximumLength(32)
                .WithMessage("The length should not be more than 32");

            RuleFor(x => x.Surname)
                .NotNull()
                .NotEmpty()
                .WithMessage("Name cannot be empty")
                .MaximumLength(64)
                .WithMessage("The length should not be more than 64");
        }
    }
}
