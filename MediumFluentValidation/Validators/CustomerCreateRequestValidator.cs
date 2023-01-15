using FluentValidation;
using MediumFluentValidation.Models;

namespace MediumFluentValidation.Validators;

public class CustomerCreateRequestValidator : AbstractValidator<CustomerCreateRequest>
{
    public CustomerCreateRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().Length(0,100);
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.Phone).NotEmpty().Matches(@"^\d{3}-\d{3}-\d{4}$");
    }
}