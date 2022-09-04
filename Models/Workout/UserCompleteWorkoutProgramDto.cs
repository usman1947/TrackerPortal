using System.ComponentModel.DataAnnotations;
using WebApi.Entities;
namespace WebApi.Models.Workout;

public class UserCompleteWorkoutProgramDto
{
    public long Id { get; set; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public long Age { get; set; }
    public ICollection<WorkoutProgramWithWorkoutDto> WorkoutPrograms { get; set; }
}