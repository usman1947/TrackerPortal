
namespace WebApi.Services;

using WebApi.Entities;
using WebApi.Models.Workout;

public interface IWorkoutService
{
    Task<ResultLog<List<Workout>>> GetAll();
    Task<ResultLog<Workout>> GetById(long id);
    Task<ResultLog<Workout>> CreateWorkout(AddWorkoutDto dto);
}