using System.ComponentModel.DataAnnotations;
using WebApi.Entities;
namespace WebApi.Models.Workout;

public class WorkoutWithExerciseDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public WorkoutTypeEnum WorkoutType { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public ICollection<Exercise> Exercises { get; set; }
}