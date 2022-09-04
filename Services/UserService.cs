namespace WebApi.Services;

using AutoMapper;
using BCrypt.Net;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Users;
using WebApi.Models.Workout;
using Microsoft.EntityFrameworkCore;

public class UserService : IUserService
{
    private DataContext _db;
    private readonly IMapper _mapper;
    protected readonly ILogger<UserService> _logger;
    private IWorkoutProgramUserMappingService _workoutProgramUserMappingService;
    private IWorkoutProgramMappingService _workoutProgramMappingService;


    public UserService(
        DataContext db,
        ILogger<UserService> logger, 
        IWorkoutProgramUserMappingService workoutProgramUserMappingService,
        IWorkoutProgramMappingService workoutProgramMappingService,
        IMapper mapper)
    {
        _db = db;
        _logger = logger;
        _mapper = mapper;
        _workoutProgramUserMappingService = workoutProgramUserMappingService;
        _workoutProgramMappingService = workoutProgramMappingService;
    }

    async public Task<ResultLog<List<User>>> GetAll()
    {
        var users = await _db.Users.Include(x => x.Country).ToListAsync();
        return ResultLog<List<User>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, users);
    }

    async public Task<ResultLog<User>> GetById(long id)
    {
        return await GetUser(id);
    }

    async public Task<ResultLog<UserCompleteWorkoutProgramDto>> GetUserWorkoutPrograms(long id)
    {
        var user = await GetUser(id);
        if (user.Success == false)
            return ResultLog<UserCompleteWorkoutProgramDto>.CreateFail(TranslationConstant._NOT_FOUND); 
            
        var userWorkoutProgramMappings = await _workoutProgramUserMappingService.GetAllByUserId(id);
        if (userWorkoutProgramMappings.Success == false)
            return ResultLog<UserCompleteWorkoutProgramDto>.CreateFail(TranslationConstant._NOT_FOUND); 

        var programs = userWorkoutProgramMappings.Data.Select(p => p.WorkoutProgram).ToList();
        var programDtoList = await _workoutProgramMappingService.GetAllWorkoutsForPrograms(programs);
        var userWorkouts = _mapper.Map<UserCompleteWorkoutProgramDto>(user.Data);
        userWorkouts.WorkoutPrograms = programDtoList.Data;
        
        return ResultLog<UserCompleteWorkoutProgramDto>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, userWorkouts); 
    }

    public ResultLog<User> Create(CreateUserDto model)
    {
        // validate
        if (_db.Users.Any(x => x.Email == model.Email))
            throw new AppException("User with the email '" + model.Email + "' already exists");

        // map model to new user object
        var user = _mapper.Map<User>(model);
        // hash password
        user.PasswordHash = BCrypt.HashPassword(model.Password);

        // save user
        _db.Users.Add(user);
        _db.SaveChanges();
        return ResultLog<User>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, user);
    }

    async public Task<ResultLog<User>> Update(long id, UpdateUserDto model)
    {
        var result = await GetUser(id);
        if (result.Success == false)
        {
            return result;
        }
        var user = result.Data;

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
        return ResultLog<User>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, user); 
    }

    async public Task<ResultLog<User>> Delete(long id)
    {
        var result = await GetUser(id);
        if (result.Success == false)
        {
            return result;
        }
        var user = result.Data;
        _db.Users.Remove(user);
        _db.SaveChanges();
        return ResultLog<User>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS);
    }

    // helper methods
    async private Task<ResultLog<User>> GetUser(long id)
    {
        var user = await _db.Users
                        .Include(user => user.Country)
                        .Where(user => user.Id == id)
                        .FirstOrDefaultAsync();
        if (user == null)
        {
            _logger.LogError("User not found userId: {userId}", id);
            return ResultLog<User>.CreateFail(TranslationConstant._NOT_FOUND);
        } 
        return ResultLog<User>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, user);
    }
}