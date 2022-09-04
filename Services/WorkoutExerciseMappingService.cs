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

    async public Task<ResultLog<List<WorkoutWithExerciseDto>>> GetWorkoutsWithExercises(List<Workout> workouts)
    {
        var workoutOutDtoList = new List<WorkoutWithExerciseDto>();

        foreach (var workout in workouts)
        {
            //adding workout info
            var workoutOutDto = _mapper.Map<WorkoutWithExerciseDto>(workout);
            workoutOutDtoList.Add(workoutOutDto);

            //adding exercise info with sets
            var exercisesForWorkoutMapping = await GetAllByWorkoutId(workout.Id);
            if (exercisesForWorkoutMapping.Success == false)
            {
                _logger.LogInformation("No exercise found for workout Id : {id}, Name : {name}", workout.Id, workout.Name);
                continue;
            }
            var exercisesInWorkout = exercisesForWorkoutMapping.Data.Select(m => m.Exercise).ToList();
            workoutOutDto.Exercises = exercisesInWorkout;
        }

        return ResultLog<List<WorkoutWithExerciseDto>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, workoutOutDtoList);
    }
}