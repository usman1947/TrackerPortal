namespace WebApi;

public class WorkoutProgramUserMapping
{
    public long WorkoutProgramId { get; set; }
    public WorkoutProgram WorkoutProgram { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public DateTime CreatedDate { get; set; }
}