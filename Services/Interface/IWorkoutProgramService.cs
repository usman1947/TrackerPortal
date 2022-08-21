
namespace WebApi.Services;

using WebApi.Entities;
using WebApi.Models.Workout;

public interface IWorkoutProgramService
{
    Task<ResultLog<List<WorkoutProgram>>> GetAll();
    Task<ResultLog<WorkoutProgram>> GetById(long id);
    Task<ResultLog<WorkoutProgram>> CreateWorkoutProgram(AddWorkoutProgramDto dto);
}