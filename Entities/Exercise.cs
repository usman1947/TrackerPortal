namespace WebApi;

public class Exercise
{
    public long Id { get; set; }
    public string Name { get; set; }
    public BodyPartEnum BodyPart { get; set; }
    public ICollection<Set> Sets { get; set; }
}