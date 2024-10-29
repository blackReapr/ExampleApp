using FluentValidation;

namespace FullIdentity.Dtos.CustomerDtos;

public class CustomerCreateDto
{
    public string ResponsibleFullName { get; set; }
    public string Phone { get; set; }
}

public class CustomerCreateDtoValidator : AbstractValidator<CustomerCreateDto>
{
    public CustomerCreateDtoValidator()
    {
        RuleFor(c => c.ResponsibleFullName).MinimumLength(8).MaximumLength(30);
        RuleFor(c => c.Phone).Matches(@"^\+994\d{9}$");
    }
}
