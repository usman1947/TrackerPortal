using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities;
namespace WebApi.Configurations
{
    public class WorkoutProgramUserMappingConfiguration : IEntityTypeConfiguration<WorkoutProgramUserMapping>
    {
        public void Configure(EntityTypeBuilder<WorkoutProgramUserMapping> builder)
        {
            builder.ToTable("WorkoutProgramUserMapping");

            builder.HasKey(w => new { w.UserId, w.WorkoutProgramId });
        }
    }
}
