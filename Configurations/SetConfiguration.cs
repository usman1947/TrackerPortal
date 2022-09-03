using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities;
namespace WebApi.Configurations
{
    public class SetConfiguration : IEntityTypeConfiguration<Set>
    {
        public void Configure(EntityTypeBuilder<Set> builder)
        {
            builder.ToTable("Set");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(e => e.ExerciseId).IsRequired();
            
            builder.HasOne(s => s.Exercise)
                .WithMany(b => b.Sets)
                .HasForeignKey(s => s.ExerciseId);
        }
    }
}
