using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaseLibrary.Entities;

[Table("application_users")]
public class ApplicationUser
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("fullname")]
    public string? Fullname { get; set; }
    
    [Column("email")]
    public string? Email { get; set; }
    
    [Column("password")]
    public string? Password { get; set; }
}