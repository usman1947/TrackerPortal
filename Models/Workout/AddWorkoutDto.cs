namespace WebApi.Models.Workout;

using System.ComponentModel.DataAnnotations;

public class AddWorkoutDto
{
    [Required]
    public string Name { get; set; }
    public WorkoutTypeEnum WorkoutType { get; set; }
    [Required]
    public long WorkoutProgramId { get; set; }
}