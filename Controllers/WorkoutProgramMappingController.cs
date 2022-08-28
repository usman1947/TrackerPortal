namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class WorkoutProgramMappingController : ControllerBase
{
    private IWorkoutProgramMappingService _workoutProgramMappingService;
    private IMapper _mapper;

    public WorkoutProgramMappingController(
        IWorkoutProgramMappingService workoutProgramMappingService,
        IMapper mapper)
    {
        _workoutProgramMappingService = workoutProgramMappingService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var mappings = await _workoutProgramMappingService.GetAll();
        return Ok(mappings);
    }

    [HttpGet("workout/{id}")]
    public async Task<IActionResult> GetAllByWorkoutId(long id)
    {
        var program = await _workoutProgramMappingService.GetAllByWorkoutId(id);
        return Ok(program);
    }

    [HttpGet("workoutProgram/{id}")]
    public async Task<IActionResult> GetAllByWorkoutProgramId(long id)
    {
        var program = await _workoutProgramMappingService.GetAllByWorkoutProgramId(id);
        return Ok(program);
    }
}