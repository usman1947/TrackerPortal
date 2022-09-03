namespace WebApi.Entities;

public class WorkoutProgramUserMapping : IAuditable
{
    public long WorkoutProgramId { get; set; }
    public WorkoutProgram WorkoutProgram { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}