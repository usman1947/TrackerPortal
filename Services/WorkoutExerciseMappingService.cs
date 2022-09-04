namespace WebApi.Services;

using AutoMapper;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Workout;
using Microsoft.EntityFrameworkCore;

public class WorkoutExerciseMappingService : IWorkoutExerciseMappingService
{
    private DataContext _db;
    private readonly IMapper _mapper;
    protected readonly ILogger<WorkoutExerciseMappingService> _logger;


    public WorkoutExerciseMappingService(
        DataContext db,
        ILogger<WorkoutExerciseMappingService> logger, 
        IMapper mapper)
    {
        _db = db;
        _logger = logger;
        _mapper = mapper;
    }

    async public Task<ResultLog<List<WorkoutExerciseMapping>>> GetAllByWorkoutId(long Id)
    {
        var exercises = await _db.WorkoutExerciseMappings
                                .Where(x => x.WorkoutId == Id)
                                .Include(x => x.Exercise)
                                .ThenInclude(x => x.Sets)
                                .Include(x => x.Workout)
                                .ToListAsync();

        if (exercises.Count == 0)
            return ResultLog<List<WorkoutExerciseMapping>>.CreateFail(TranslationConstant._NOT_FOUND);
            
        return ResultLog<List<WorkoutExerciseMapping>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, exercises);
    }
}