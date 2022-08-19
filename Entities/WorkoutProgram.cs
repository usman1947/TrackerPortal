namespace WebApi;

public class WorkoutProgram
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<Workout> Workouts { get; set; }
    public DateTime CreatedDate { get; set; }
}