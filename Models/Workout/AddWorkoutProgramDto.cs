namespace WebApi.Models.Workout;

using System.ComponentModel.DataAnnotations;

public class AddWorkoutProgramDto
{
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    [Required]
    public long UserId { get; set; }
}