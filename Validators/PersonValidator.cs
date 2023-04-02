using FluentValidation;
using ApiRequestValidation.Entities;

namespace ApiRequestValidation.Validators;

public class PersonValidator : AbstractValidator<Person>
{
    public PersonValidator()
    {
        RuleFor(p => p.Name).NotNull();
        RuleFor(p => p.Name).NotEmpty();
        RuleFor(p => p.Name).MaximumLength(50);
        RuleFor(p => p.Name).MinimumLength(4);

        RuleFor(p => p.Email).NotNull().NotEmpty().EmailAddress();

        RuleFor(p => p.BirthDate).NotEmpty();
        RuleFor(p => p.BirthDate).GreaterThan(new DateTime(1900, 1, 1));

        RuleFor(p => p.VAT).NotNull().NotEmpty();
        RuleFor(p => p.VAT).SetValidator(new VatValidator());

        RuleFor(p => p.Address1).NotNull().NotEmpty().Length(10, 200);
    }
}