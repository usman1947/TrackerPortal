namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class WorkoutProgramUserMappingController : ControllerBase
{
    private IWorkoutProgramUserMappingService _workoutProgramUserMappingService;
    private IMapper _mapper;

    public WorkoutProgramUserMappingController(
        IWorkoutProgramUserMappingService workoutProgramUserMappingService,
        IMapper mapper)
    {
        _workoutProgramUserMappingService = workoutProgramUserMappingService;
        _mapper = mapper;
    }

    [HttpGet("user/{id}")]
    public async Task<IActionResult> GetAllByUserId(long id)
    {
        var program = await _workoutProgramUserMappingService.GetAllByUserId(id);
        return Ok(program);
    }

    [HttpPost("user/{userId}/workoutProgram/{workoutProgramId}")]
    public async Task<IActionResult> LinkWorkoutProgramToUser(long userId, long workoutProgramId)
    {
        var program = await _workoutProgramUserMappingService.LinkWorkoutProgramToUser(userId, workoutProgramId);
        return Ok(program);
    }
}