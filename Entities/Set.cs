namespace WebApi;

public class Set
{
    public long Id { get; set; }
    public long TargetCount { get; set; }
    public long AchievedCount { get; set; }
    public long TargetWeight { get; set; }
    public long AchievedWeight { get; set; }
    public long ExerciseId { get; set; }
    public Exercise Exercise { get; set; }
    public DateTime CreatedDate { get; set; }
}