
namespace WebApi.Services;

using WebApi.Entities;
using WebApi.Models.Users;

public interface IWorkoutProgramService
{
    Task<ResultLog<List<WorkoutProgram>>> GetAll();
    Task<ResultLog<WorkoutProgram>> GetById(long id);
}