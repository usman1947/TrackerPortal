using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities;
namespace WebApi.Configurations
{
    public class WorkoutProgramMappingConfiguration : IEntityTypeConfiguration<WorkoutProgramMapping>
    {
        public void Configure(EntityTypeBuilder<WorkoutProgramMapping> builder)
        {
            builder.ToTable("WorkoutProgramMapping");

            builder.HasKey(w => new { w.WorkoutProgramId, w.WorkoutId });
        }
    }
}
