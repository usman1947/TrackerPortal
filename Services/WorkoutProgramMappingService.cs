namespace WebApi.Services;

using AutoMapper;
using WebApi.Entities;
using WebApi.Helpers;
using Microsoft.EntityFrameworkCore;

public class WorkoutProgramMappingService : IWorkoutProgramMappingService
{
    private DataContext _db;
    private readonly IMapper _mapper;
    private IUserService _userService;
    protected readonly ILogger<WorkoutProgramMappingService> _logger;


    public WorkoutProgramMappingService(
        DataContext db,
        IUserService userService,
        ILogger<WorkoutProgramMappingService> logger, 
        IMapper mapper)
    {
        _db = db;
        _logger = logger;
        _userService = userService;
        _mapper = mapper;
    }

    async public Task<ResultLog<List<WorkoutProgramMapping>>> GetAll()
    {
        var mappings = await _db.WorkoutProgramMappings
                                .Include(m => m.Workout)
                                .Include(m => m.WorkoutProgram)
                                .ToListAsync();
        return ResultLog<List<WorkoutProgramMapping>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, mappings);
    }

    async public Task<ResultLog<List<WorkoutProgramMapping>>> GetAllByWorkoutId(long workoutId)
    {
        var mappings = await _db.WorkoutProgramMappings
                        .Where(p => p.WorkoutId == workoutId)
                        .Include(m => m.Workout)
                        .Include(m => m.WorkoutProgram)
                        .ToListAsync();

        return ResultLog<List<WorkoutProgramMapping>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, mappings);
    }

    async public Task<ResultLog<List<WorkoutProgramMapping>>> GetAllByWorkoutProgramId(long workoutProgramId)
    {
        var mappings = await _db.WorkoutProgramMappings
                        .Where(p => p.WorkoutProgramId == workoutProgramId)
                        .Include(m => m.Workout)
                        .Include(m => m.WorkoutProgram)
                        .ToListAsync();

        return ResultLog<List<WorkoutProgramMapping>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, mappings);
    }

}