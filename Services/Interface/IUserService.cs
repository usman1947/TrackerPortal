
namespace WebApi.Services;

using WebApi.Entities;
using WebApi.Models.Users;
using WebApi.Models.Workout;

public interface IUserService
{
    Task<ResultLog<List<User>>> GetAll();
    Task<ResultLog<User>> GetById(long id);
    ResultLog<User> Create(CreateUserDto model);
    Task<ResultLog<User>> Update(long id, UpdateUserDto model);
    Task<ResultLog<User>> Delete(long id);
    Task<ResultLog<UserCompleteWorkoutProgramDto>> GetUserWorkoutPrograms(long id);
}