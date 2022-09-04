using System.ComponentModel.DataAnnotations;
using WebApi.Entities;
namespace WebApi.Models.Workout;

public class WorkoutProgramWithWorkoutDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public ICollection<WorkoutWithExerciseDto> Workouts { get; set; }
}