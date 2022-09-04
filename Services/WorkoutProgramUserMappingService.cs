namespace WebApi.Services;

using AutoMapper;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Workout;
using Microsoft.EntityFrameworkCore;

public class WorkoutProgramUserMappingService : IWorkoutProgramUserMappingService
{
    private DataContext _db;
    private readonly IMapper _mapper;
    protected readonly ILogger<WorkoutProgramUserMappingService> _logger;


    public WorkoutProgramUserMappingService(
        DataContext db,
        ILogger<WorkoutProgramUserMappingService> logger, 
        IMapper mapper)
    {
        _db = db;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<ResultLog<List<WorkoutProgramUserMapping>>> GetAllByUserId(long userId)
    {
        var mappings = await _db.WorkoutProgramUserMappings.Where(w => w.UserId == userId)
                                                            .Include(w => w.User)
                                                            .Include(w => w.WorkoutProgram)
                                                            .ToListAsync();
        if (mappings.Count == 0)
        {
            _logger.LogError("No workout programs found for this UserId: {userId}", userId);
            return ResultLog<List<WorkoutProgramUserMapping>>.CreateFail(TranslationConstant._NOT_FOUND); 
        }                                                  
        return ResultLog<List<WorkoutProgramUserMapping>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, mappings);                                                   
    }

    public async Task<ResultLog<WorkoutProgramUserMapping>> LinkWorkoutProgramToUser(long userId, long workoutProgramId)
    {
        _logger.LogInformation("Linking WorkoutProgramId: {workoutProgramId} with UserId: {userId}", workoutProgramId, userId);
        WorkoutProgramUserMapping mapping = new WorkoutProgramUserMapping()
        {
            UserId = userId,
            WorkoutProgramId = workoutProgramId
        };
        _db.Add(mapping);
        var result = await _db.SaveChangesAsync();

        if (result == 0)
            return ResultLog<WorkoutProgramUserMapping>.CreateFail(TranslationConstant._OPERATION_FAIL);

        return ResultLog<WorkoutProgramUserMapping>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, mapping);
    }
}