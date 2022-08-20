namespace WebApi;

public class WorkoutExerciseMapping
{
    public long WorkoutId { get; set; }
    public Workout Workout { get; set; }
    public long ExerciseId { get; set; }
    public Exercise Exercise { get; set; }
    public DateTime CreatedDate { get; set; }
}