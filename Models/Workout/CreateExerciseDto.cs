namespace WebApi.Models.Workout;

using System.ComponentModel.DataAnnotations;

public class CreateExerciseDto
{
    [Required]
    public string Name { get; set; }
    [Required]
    public BodyPartEnum BodyPartEnum { get; set; }
    [Required]
    public long WorkoutId { get; set; }
    public ICollection<Set> Sets { get; set; }
}