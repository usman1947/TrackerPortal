using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApi.Configurations
{
    public class WorkoutProgramConfiguration : IEntityTypeConfiguration<WorkoutProgram>
    {
        public void Configure(EntityTypeBuilder<WorkoutProgram> builder)
        {
            builder.ToTable("WorkoutProgram");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd()
                .IsRequired();
        }
    }
}
