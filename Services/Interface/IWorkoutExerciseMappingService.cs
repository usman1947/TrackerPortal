
namespace WebApi.Services;

using WebApi.Entities;

public interface IWorkoutExerciseMappingService
{
    Task<ResultLog<List<WorkoutExerciseMapping>>> GetAllByWorkoutId(long id);
}