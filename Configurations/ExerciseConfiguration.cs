using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApi.Configurations
{
    public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.ToTable("Exercise");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.HasMany(e => e.Sets)
                .WithOne(v => v.Exercise)
                .HasForeignKey(v => v.ExerciseId);
                
            builder.Navigation(e => e.Sets).AutoInclude();
        }
    }
}
