namespace WebApi.Services;

using AutoMapper;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Workout;
using Microsoft.EntityFrameworkCore;

public class ExerciseService : IExerciseService
{
    private DataContext _db;
    private readonly IMapper _mapper;
    protected readonly ILogger<ExerciseService> _logger;


    public ExerciseService(
        DataContext db,
        ILogger<ExerciseService> logger, 
        IMapper mapper)
    {
        _db = db;
        _logger = logger;
        _mapper = mapper;
    }

    async public Task<ResultLog<List<Exercise>>> GetAll()
    {
        var exercises = await _db.Exercises.ToListAsync();
        return ResultLog<List<Exercise>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, exercises);
    }

    async public Task<ResultLog<List<Exercise>>> GetAllByBodyPart(BodyPartEnum bodyPartId)
    {
        var exercises = await _db.Exercises
                              .Where(x => x.BodyPart == bodyPartId)
                              .ToListAsync();
        return ResultLog<List<Exercise>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, exercises);
    }

    public async Task<ResultLog<Exercise>> CreateExercise(CreateExerciseDto dto)
    {
        try
        {
            Exercise exercise = new Exercise()
            {
                Name = dto.Name,
                BodyPart = dto.BodyPartEnum,
                Sets = dto.Sets
            };
            _db.Add(exercise);
            await _db.SaveChangesAsync();
            _logger.LogInformation("Added exercise Id: {}", exercise.Id);
            WorkoutExerciseMapping mapping = new WorkoutExerciseMapping()
            {
                WorkoutId = dto.WorkoutId,
                ExerciseId = exercise.Id,
                CreatedDate = DateTime.UtcNow
            };
            _db.Add(mapping);
            await _db.SaveChangesAsync();

            return ResultLog<Exercise>.CreateSuccess("Saves exercise", exercise);
        }
        catch (Exception e)
        {
            _logger.LogError("Error happened in CreateExercise", e);
            return ResultLog<Exercise>.CreateFail("Failed to save exercise");
        }
        
    }
}