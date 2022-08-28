
namespace WebApi.Services;

using WebApi.Entities;

public interface IWorkoutProgramMappingService
{
    Task<ResultLog<List<WorkoutProgramMapping>>> GetAll();
    public Task<ResultLog<List<WorkoutProgramMapping>>> GetAllByWorkoutProgramId(long workoutProgramId);
    public Task<ResultLog<List<WorkoutProgramMapping>>> GetAllByWorkoutId(long workoutId);
}