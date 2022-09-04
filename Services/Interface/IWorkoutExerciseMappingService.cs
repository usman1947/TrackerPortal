
namespace WebApi.Services;

using WebApi.Entities;
using WebApi.Models.Workout;

public interface IWorkoutExerciseMappingService
{
    Task<ResultLog<List<WorkoutExerciseMapping>>> GetAllByWorkoutId(long id);
    Task<ResultLog<List<WorkoutWithExerciseDto>>> GetWorkoutsWithExercises(List<Workout> workouts);
}