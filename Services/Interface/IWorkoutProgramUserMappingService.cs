
namespace WebApi.Services;

using WebApi.Entities;
using WebApi.Models.Workout;

public interface IWorkoutProgramUserMappingService
{
    Task<ResultLog<List<WorkoutProgramUserMapping>>> GetAllByUserId(long userId);
}