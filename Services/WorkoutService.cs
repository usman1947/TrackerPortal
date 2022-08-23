namespace WebApi.Services;

using AutoMapper;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Workout;
using Microsoft.EntityFrameworkCore;

public class WorkoutService : IWorkoutService
{
    private DataContext _db;
    private readonly IMapper _mapper;
    private IWorkoutProgramService _workoutProgramService;
    protected readonly ILogger<IWorkoutService> _logger;


    public WorkoutService(
        DataContext db,
        IWorkoutProgramService workoutProgramService,
        ILogger<IWorkoutService> logger, 
        IMapper mapper)
    {
        _db = db;
        _logger = logger;
        _workoutProgramService = workoutProgramService;
        _mapper = mapper;
    }

    async public Task<ResultLog<List<Workout>>> GetAll()
    {
        var programs = await _db.Workouts.ToListAsync();
        return ResultLog<List<Workout>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, programs);
    }

    async public Task<ResultLog<Workout>> GetById(long id)
    {
        return await getWorkout(id);
    }

    async public Task<ResultLog<Workout>> CreateWorkout(AddWorkoutDto dto)
    {
        var result = await _workoutProgramService.GetById(dto.WorkoutProgramId);
        if (result.Success == false)
        {
            return ResultLog<Workout>.CreateFail("Cannot create a workout without a workout program");
        }

        Workout workout = new ()
        {
            Name = dto.Name,
            WorkoutType = dto.WorkoutType,
            CreatedDate = DateTime.UtcNow
        };
        _db.Workouts.Add(workout);
        _db.SaveChanges();

        WorkoutProgramMapping mapping = new ()
        {
            WorkoutProgramId = dto.WorkoutProgramId,
            WorkoutId = workout.Id,
            CreatedDate = DateTime.UtcNow
        };
        _db.WorkoutProgramMappings.Add(mapping);
        _db.SaveChanges();
        
        _logger.LogInformation("Added workout to program");
        return ResultLog<Workout>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, workout);
    }

    // helper methods
    async private Task<ResultLog<Workout>> getWorkout(long id)
    {
        var program = await _db.Workouts
                        .Where(p => p.Id == id)
                        .FirstOrDefaultAsync();
        if (program == null) 
        {
            return ResultLog<Workout>.CreateFail(TranslationConstant._NOT_FOUND);
        }
        return ResultLog<Workout>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, program);;
    }
}