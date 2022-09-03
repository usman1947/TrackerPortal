using System.ComponentModel.DataAnnotations;
using WebApi.Entities;
namespace WebApi.Models.Workout;

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