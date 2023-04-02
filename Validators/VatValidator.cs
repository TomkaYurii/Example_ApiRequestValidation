using FluentValidation;
using FluentValidation.Validators;
using ApiRequestValidation.Entities;

namespace ApiRequestValidation.Validators;

public class VatValidator : IPropertyValidator<Person, int?>
{
    public string Name => "VAT";

    public string GetDefaultMessageTemplate(string errorCode)
    {
        return "VAT contains 1111";
    }

    public bool IsValid(ValidationContext<Person> context, int? value)
    {
        if (!value.HasValue)
            return false;

        if (value.Value.ToString().Contains("1111"))
        {
            return false;
        }

        return true;
    }
}