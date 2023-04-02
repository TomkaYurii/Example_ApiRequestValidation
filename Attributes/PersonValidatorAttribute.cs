using System.ComponentModel.DataAnnotations;
using ApiRequestValidation.Entities;
using ApiRequestValidation.Validators;

namespace ApiRequestValidation.Attributes;

public class PersonValidatorAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value == null)
            return false;

        var validator = new PersonValidator();
        var result = validator.Validate((Person)value!);

        this.ErrorMessage = result.ToString();
        return result.IsValid;
    }
}