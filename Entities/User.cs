using System.Text.Json.Serialization;
namespace WebApi.Entities;

public class User : IAuditable
{
    public long Id { get; set; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public long Age { get; set; }
    public string Email { get; set; }
    public long LanguageId { get; set; }
    public long CountryId { get; set; }
    public Country Country { get; set; }
    [JsonIgnore]
    public string PasswordHash { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}