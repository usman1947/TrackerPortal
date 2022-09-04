using WebApi.Entities;
using WebApi.Models.Workout;
namespace WebApi.Services;

public interface IWorkoutProgramMappingService
{
    Task<ResultLog<List<WorkoutProgramMapping>>> GetAll();
    public Task<ResultLog<List<WorkoutProgramMapping>>> GetAllByWorkoutProgramId(long workoutProgramId);
    public Task<ResultLog<List<WorkoutProgramMapping>>> GetAllByWorkoutId(long workoutId);
    Task<ResultLog<List<WorkoutProgramWithWorkoutDto>>> GetAllWorkoutsForPrograms(List<WorkoutProgram> programs);
}