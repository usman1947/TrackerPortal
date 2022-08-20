
namespace WebApi.Services;

using WebApi.Entities;
using WebApi.Models.Users;

public interface IWorkoutProgramService
{
    Task<List<WorkoutProgram>> GetAll();
    Task<WorkoutProgram> GetById(long id);
}