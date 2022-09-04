namespace WebApi.Controllers;

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Users;
using WebApi.Services;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private IUserService _userService;
    private IMapper _mapper;

    public UsersController(
        IUserService userService,
        IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users = await _userService.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(long id)
    {
        var user = await _userService.GetById(id);
        return Ok(user);
    }

    [HttpGet("{id}/workoutPrograms")]
    public async Task<IActionResult> GetUserWorkoutPrograms(long id)
    {
        var user = await _userService.GetUserWorkoutPrograms(id);
        return Ok(user);
    }

    [HttpPost]
    public IActionResult Create(CreateUserDto model)
    {
        _userService.Create(model);
        return Ok(new { message = "User created" });
    }

    [HttpPut("{id}")]
    public IActionResult Update(long id, UpdateUserDto model)
    {
        _userService.Update(id, model);
        return Ok(new { message = "User updated" });
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(long id)
    {
        _userService.Delete(id);
        return Ok(new { message = "User deleted" });
    }
}