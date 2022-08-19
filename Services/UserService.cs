namespace WebApi.Services;

using AutoMapper;
using BCrypt.Net;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Users;
using Microsoft.EntityFrameworkCore;
public interface IUserService
{
    Task<List<User>> GetAll();
    Task<User> GetById(long id);
    void Create(CreateRequest model);
    void Update(long id, UpdateRequest model);
    void Delete(long id);
}

public class UserService : IUserService
{
    private DataContext _db;
    private readonly IMapper _mapper;

    public UserService(
        DataContext db,
        IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    async public Task<List<User>> GetAll()
    {
        var users = await _db.Users.Include(x => x.Country).ToListAsync();
        return users;
    }

    async public Task<User> GetById(long id)
    {
        return await getUser(id);
    }

    public void Create(CreateRequest model)
    {
        // validate
        if (_db.Users.Any(x => x.Email == model.Email))
            throw new AppException("User with the email '" + model.Email + "' already exists");

        // map model to new user object
        var user = _mapper.Map<User>(model);
        user.CreatedDate = DateTime.UtcNow;
        // hash password
        user.PasswordHash = BCrypt.HashPassword(model.Password);

        // save user
        _db.Users.Add(user);
        _db.SaveChanges();
    }

    async public void Update(long id, UpdateRequest model)
    {
        var user = await getUser(id);

        // validate
        if (model.Email != user.Email && _db.Users.Any(x => x.Email == model.Email))
            throw new AppException("User with the email '" + model.Email + "' already exists");

        // hash password if it was entered
        if (!string.IsNullOrEmpty(model.Password))
            user.PasswordHash = BCrypt.HashPassword(model.Password);

        // copy model to user and save
        _mapper.Map(model, user);
        _db.Users.Update(user);
        _db.SaveChanges();
    }

    async public void Delete(long id)
    {
        var user = await getUser(id);
        _db.Users.Remove(user);
        _db.SaveChanges();
    }

    // helper methods
    async private Task<User> getUser(long id)
    {
        var user = await _db.Users
                        .Include(user => user.Country)
                        .Where(user => user.Id == id)
                        .FirstOrDefaultAsync();
        if (user == null) throw new KeyNotFoundException("User not found");
        return user;
    }
}