using System.ComponentModel.DataAnnotations;

namespace ApiRequestValidation.Entities;

public class Product
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    [MinLength(4)]
    public string? Name { get; set; }

    [Required]
    [StringLength(200)]
    public String? Description { get; set; }

    [Required]
    public DateTime ManufacturingDate { get; set; }

    [Required]
    [DataType(DataType.Currency)]
    public double? Price { get; set; }

    [Required]
    public String? Category { get; set; }

}