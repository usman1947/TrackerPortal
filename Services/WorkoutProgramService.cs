namespace WebApi.Services;

using AutoMapper;
using BCrypt.Net;
using WebApi.Entities;
using WebApi.Helpers;
using WebApi.Models;
using Microsoft.EntityFrameworkCore;

public class WorkoutProgramService : IWorkoutProgramService
{
    private DataContext _db;
    private readonly IMapper _mapper;

    public WorkoutProgramService(
        DataContext db,
        IMapper mapper)
    {
        _db = db;
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