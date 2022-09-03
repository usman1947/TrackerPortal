using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities;
namespace WebApi.Configurations
{
    public class WorkoutExerciseMappingConfiguration : IEntityTypeConfiguration<WorkoutExerciseMapping>
    {
        public void Configure(EntityTypeBuilder<WorkoutExerciseMapping> builder)
        {
            builder.ToTable("WorkoutExerciseMapping");

            builder.HasKey(w => new { w.WorkoutId, w.ExerciseId });
        }
    }
}
