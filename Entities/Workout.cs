namespace WebApi;

public class Workout
{
    public long Id { get; set; }
    public string Name { get; set; }
    public WorkoutTypeEnum WorkoutType { get; set; }
    public ICollection<Exercise> Exercises { get; set; }
    public DateTime CreatedDate { get; set; }
}