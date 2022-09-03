namespace WebApi.Entities;

public class Exercise : IAuditable
{
    public long Id { get; set; }
    public string Name { get; set; }
    public BodyPartEnum BodyPart { get; set; }
    public ICollection<Set> Sets { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}