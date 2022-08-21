namespace WebApi.Models.Workout;

using System.ComponentModel.DataAnnotations;

public class AddWorkoutProgramDto
{
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public long UserId { get; set; }
}