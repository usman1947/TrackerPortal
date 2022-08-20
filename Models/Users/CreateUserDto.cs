namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;

public class CreateUserDto
{
    [Required]
    public string GivenName { get; set; }
    [Required]
    public string Surname { get; set; }
    [Required]
    public long Age { get; set; }
    [Required]
    public long CountryId { get; set; }
    [Required]
    public long LanguageId { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [MinLength(6)]
    public string Password { get; set; }
    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}