using ApiRequestValidation.Attributes;
using request_validation.Attributes;
using System.ComponentModel.DataAnnotations;

namespace ApiRequestValidation.Entities;

//public class Person
//{
//    public int Id { get; set; }
//    public string? Name { get; set; }
//    public string? Email { get; set; }
//    public DateTime BirthDate { get; set; }
//    public int? VAT { get; set; }
//    public String? Address1 { get; set; }
//    public String? Address2 { get; set; }
//}




// Data Annotation + Binding + Custom Properety Attribute
//public class Person
//{
//    public int Id { get; set; }

//    [Required]
//    [MaxLength(50)]
//    [MinLength(4)]
//    public string? Name { get; set; }

//    [Required]
//    [EmailAddress]
//    public string? Email { get; set; }

//    [Required]
//    public DateTime BirthDate { get; set; }

//    [Required]
//    [VatValidator]
//    public int? VAT { get; set; }

//    [Required]
//    public String? Address1 { get; set; }

//    public String? Address2 { get; set; }
//}



// Fluent Validation + Attributes
[PersonValidator]
public class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public DateTime BirthDate { get; set; }
    public int? VAT { get; set; }
    public String? Address1 { get; set; }
    public String? Address2 { get; set; }
}