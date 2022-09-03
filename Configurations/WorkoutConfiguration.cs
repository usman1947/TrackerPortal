using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities;
namespace WebApi.Configurations
{
    public class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
    {
        public void Configure(EntityTypeBuilder<Workout> builder)
        {
            builder.ToTable("Workout");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd()
                .IsRequired();
        }
    }
}
