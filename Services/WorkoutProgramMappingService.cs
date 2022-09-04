namespace WebApi.Services;

using AutoMapper;
using WebApi.Entities;
using WebApi.Helpers;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.Workout;

public class WorkoutProgramMappingService : IWorkoutProgramMappingService
{
    private DataContext _db;
    private readonly IMapper _mapper;
    protected readonly ILogger<WorkoutProgramMappingService> _logger;
    private IWorkoutExerciseMappingService _workoutExerciseMappingService;


    public WorkoutProgramMappingService(
        DataContext db,
        ILogger<WorkoutProgramMappingService> logger, 
        IWorkoutExerciseMappingService workoutExerciseMappingService,
        IMapper mapper)
    {
        _db = db;
        _logger = logger;
        _mapper = mapper;
        _workoutExerciseMappingService = workoutExerciseMappingService;
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
                        
        if(mappings.Count == 0)
            return ResultLog<List<WorkoutProgramMapping>>.CreateFail(TranslationConstant._NOT_FOUND);

        return ResultLog<List<WorkoutProgramMapping>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, mappings);
    }

    async public Task<ResultLog<List<WorkoutProgramMapping>>> GetAllByWorkoutProgramId(long workoutProgramId)
    {
        var mappings = await _db.WorkoutProgramMappings
                        .Where(p => p.WorkoutProgramId == workoutProgramId)
                        .Include(m => m.Workout)
                        .Include(m => m.WorkoutProgram)
                        .ToListAsync();

        if(mappings.Count == 0)
            return ResultLog<List<WorkoutProgramMapping>>.CreateFail(TranslationConstant._NOT_FOUND);

        return ResultLog<List<WorkoutProgramMapping>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, mappings);
    }

    async public Task<ResultLog<List<WorkoutProgramWithWorkoutDto>>> GetAllWorkoutsForPrograms(List<WorkoutProgram> programs)
    {
        var programDtoList = new List<WorkoutProgramWithWorkoutDto>();
        foreach (var program in programs)
        {
            //adding program information
            var programDto = _mapper.Map<WorkoutProgramWithWorkoutDto>(program);
            programDtoList.Add(programDto);

            //adding workout information with exercises
            var workoutProgramMappingList = await GetAllByWorkoutProgramId(program.Id);
            if (workoutProgramMappingList.Success == false)
            {
                _logger.LogInformation("No workouts found for program Id : {id}, Name : {name}", program.Id, program.Name);
                continue;
            }
            var workoutsInProgram = workoutProgramMappingList.Data.Select(m => m.Workout).ToList();
            var workoutOutDtoList = await _workoutExerciseMappingService.GetWorkoutsWithExercises(workoutsInProgram);
            programDto.Workouts = workoutOutDtoList.Data;
        }

        return ResultLog<List<WorkoutProgramWithWorkoutDto>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, programDtoList);
    }
}