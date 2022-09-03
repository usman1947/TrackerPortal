namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Workout;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class ExerciseController : ControllerBase
{
    private IExerciseService _exerciseService;
    private IMapper _mapper;

    public ExerciseController(
        IExerciseService exerciseService,
        IMapper mapper)
    {
        _exerciseService = exerciseService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var exercises = await _exerciseService.GetAll();
        return Ok(exercises);
    }

    [HttpGet("{bodyPart}")]
    public async Task<IActionResult> GetAllByBodyPart(BodyPartEnum bodyPart)
    {
        var exercises = await _exerciseService.GetAllByBodyPart(bodyPart);
        return Ok(exercises);
    }

    [HttpPost]
    public async Task<IActionResult> CreateExercise([FromBody] CreateExerciseDto dto)
    {
        var exercise = await _exerciseService.CreateExercise(dto);
        return Ok(exercise);
    }
}