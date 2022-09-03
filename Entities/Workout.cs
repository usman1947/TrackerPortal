namespace WebApi.Entities;

public class Workout : IAuditable
{
    public long Id { get; set; }
    public string Name { get; set; }
    public WorkoutTypeEnum WorkoutType { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}