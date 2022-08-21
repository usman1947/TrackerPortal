namespace WebApi.Services;

using AutoMapper;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models.Workout;
using Microsoft.EntityFrameworkCore;

public class WorkoutProgramService : IWorkoutProgramService
{
    private DataContext _db;
    private readonly IMapper _mapper;
    private IUserService _userService;
    protected readonly ILogger<WorkoutProgramService> _logger;


    public WorkoutProgramService(
        DataContext db,
        IUserService userService,
        ILogger<WorkoutProgramService> logger, 
        IMapper mapper)
    {
        _db = db;
        _logger = logger;
        _userService = userService;
        _mapper = mapper;
    }

    async public Task<ResultLog<List<WorkoutProgram>>> GetAll()
    {
        var programs = await _db.WorkoutPrograms.ToListAsync();
        return ResultLog<List<WorkoutProgram>>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, programs);
    }

    async public Task<ResultLog<WorkoutProgram>> GetById(long id)
    {
        return await getWorkoutProgram(id);
    }

    async public Task<ResultLog<WorkoutProgram>> CreateWorkoutProgram(AddWorkoutProgramDto dto)
    {
        var result = await _userService.GetById(dto.UserId);
        if (result.Success == false)
        {
            return ResultLog<WorkoutProgram>.CreateFail("Cannot create a workout program without user");
        }

        WorkoutProgram program = new ()
        {
            Name = dto.Name,
            Description = dto.Description,
            CreatedDate = DateTime.UtcNow
        };
        _db.WorkoutPrograms.Add(program);
        _db.SaveChanges();

        WorkoutProgramUserMapping mapping = new ()
        {
            UserId = dto.UserId,
            WorkoutProgramId = program.Id,
            CreatedDate = DateTime.UtcNow
        };
        _db.WorkoutProgramUserMappings.Add(mapping);
        _db.SaveChanges();
        
        _logger.LogInformation("Adding workout program and user mapping");
        return ResultLog<WorkoutProgram>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS);
    }

    // helper methods
    async private Task<ResultLog<WorkoutProgram>> getWorkoutProgram(long id)
    {
        var program = await _db.WorkoutPrograms
                        .Where(p => p.Id == id)
                        .FirstOrDefaultAsync();
        if (program == null) 
        {
            return ResultLog<WorkoutProgram>.CreateFail(TranslationConstant._NOT_FOUND);
        }
        return ResultLog<WorkoutProgram>.CreateSuccess(TranslationConstant._OPERATION_SUCCESS, program);;
    }
}