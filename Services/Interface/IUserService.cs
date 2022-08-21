
namespace WebApi.Services;

using WebApi.Entities;
using WebApi.Models.Users;

public interface IUserService
{
    Task<ResultLog<List<User>>> GetAll();
    Task<ResultLog<User>> GetById(long id);
    ResultLog<User> Create(CreateUserDto model);
    Task<ResultLog<User>> Update(long id, UpdateUserDto model);
    Task<ResultLog<User>> Delete(long id);
}