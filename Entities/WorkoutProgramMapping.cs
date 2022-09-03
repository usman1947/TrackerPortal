namespace WebApi.Entities;

public class WorkoutProgramMapping : IAuditable
{
    public long WorkoutProgramId { get; set; }
    public WorkoutProgram WorkoutProgram { get; set; }
    public long WorkoutId { get; set; }
    public Workout Workout { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}