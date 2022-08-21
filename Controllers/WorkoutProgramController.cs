namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Workout;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class WorkoutProgramController : ControllerBase
{
    private IWorkoutProgramService _workoutProgramService;
    private IMapper _mapper;

    public WorkoutProgramController(
        IWorkoutProgramService workoutProgramService,
        IMapper mapper)
    {
        _workoutProgramService = workoutProgramService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var programs = await _workoutProgramService.GetAll();
        return Ok(programs);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(long id)
    {
        var program = await _workoutProgramService.GetById(id);
        return Ok(program);
    }

    [HttpPost]
    public async Task<IActionResult> CreateWorkoutProgram([FromBody] AddWorkoutProgramDto dto)
    {
        var program = await _workoutProgramService.CreateWorkoutProgram(dto);
        return Ok(program);
    }
}