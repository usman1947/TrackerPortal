namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Workout;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class WorkoutController : ControllerBase
{
    private IWorkoutService _workoutService;
    private IMapper _mapper;

    public WorkoutController(
        IWorkoutService workoutService,
        IMapper mapper)
    {
        _workoutService = workoutService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var programs = await _workoutService.GetAll();
        return Ok(programs);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(long id)
    {
        var program = await _workoutService.GetById(id);
        return Ok(program);
    }

    [HttpPost]
    public async Task<IActionResult> CreateWorkout([FromBody] AddWorkoutDto dto)
    {
        var program = await _workoutService.CreateWorkout(dto);
        return Ok(program);
    }
}