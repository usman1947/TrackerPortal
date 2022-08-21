
namespace WebApi.Services;

using WebApi.Entities;
using WebApi.Models.Users;

public interface IUserService
{
    Task<List<User>> GetAll();
    Task<User> GetById(long id);
    void Create(CreateUserDto model);
    void Update(long id, UpdateUserDto model);
    void Delete(long id);
}