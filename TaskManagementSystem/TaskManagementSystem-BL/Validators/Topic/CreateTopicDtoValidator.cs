using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem_BL.DTOs.TopicDtos;

namespace TaskManagementSystem_BL.Validators.Topic
{
    public class CreateTopicDtoValidator : AbstractValidator<CreateTopicDto>
    {
        public CreateTopicDtoValidator()
        {
            RuleFor(x => x.Name)
               .NotNull()
               .NotEmpty()
               .WithMessage("Name cannot be empty")
               .MaximumLength(32)
               .WithMessage("The length should not be more than 32");
        }
    }
}
