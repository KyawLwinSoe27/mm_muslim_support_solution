using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.DTOs;

public class Register : AccountBase
{
    [Required]
    [MinLength(3)]
    [MaxLength(50)]
    public string? Fullname { get; set; }
    
    [DataType(DataType.Password)]
    [Compare(nameof(Password))]
    [Required]
    public string? ConfirmPassword { get; set; }
    
}