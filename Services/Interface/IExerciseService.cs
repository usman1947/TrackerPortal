
namespace WebApi.Services;

using WebApi.Entities;
using WebApi.Models.Workout;
public interface IExerciseService
{
    Task<ResultLog<List<Exercise>>> GetAll();
    Task<ResultLog<List<Exercise>>> GetAllByBodyPart(BodyPartEnum bodyPartId);
    Task<ResultLog<Exercise>> CreateExercise(CreateExerciseDto dto);
}