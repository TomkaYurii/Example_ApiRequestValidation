using System.ComponentModel.DataAnnotations;

namespace request_validation.Attributes;

public class VatValidatorAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value == null)
            return false;

        string vat = value.ToString()!;

        if (vat.Contains("1111"))
        {
            this.ErrorMessage = "VAT містить 1111! Це не є припустимо!";
            return false;
        }

        return true;
    }
}