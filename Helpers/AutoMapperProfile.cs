namespace WebApi.Helpers;

using AutoMapper;
using WebApi.Entities;
using WebApi.Models.Users;
using WebApi.Models.Workout;


public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // CreateRequest -> User
        CreateMap<CreateUserDto, User>();

        // UpdateRequest -> User
        CreateMap<UpdateUserDto, User>()
            .ForAllMembers(x => x.Condition(
                (src, dest, prop) =>
                {
                    // ignore both null & empty string properties
                    if (prop == null) return false;
                    if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                    return true;
                }
            ));

        CreateMap<User, UserCompleteWorkoutProgramDto>().ReverseMap();
        CreateMap<WorkoutProgram, WorkoutProgramWithWorkoutDto>().ReverseMap();
        CreateMap<Workout, WorkoutWithExerciseDto>().ReverseMap();
    }
}