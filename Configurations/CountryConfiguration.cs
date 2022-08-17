using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using WebApi.Entities;

namespace WebApi.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasColumnType("bigint")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(e => e.Label).HasMaxLength(256);
            builder.Property(e => e.Value).HasMaxLength(256);

            builder.Property(e => e.Label).IsRequired();
            builder.Property(e => e.Value).IsRequired();

            builder.HasData(SeedCountryFromJson());
        }
    
        public List<Country> SeedCountryFromJson()
        {
            var countryList = new List<Country>();
            var currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string targetJson = Path.Combine(currentDirectory, "Configurations", "Fixtures", "country-list.json");
            using (StreamReader r = new StreamReader(@targetJson))
            {
                string json = r.ReadToEnd();
                List<Country> countryJson = JsonConvert.DeserializeObject<List<Country>>(json);

                foreach(var countryItem in countryJson.Select((x, i) => new { x, i }))
                {
                    countryList.Add(
                       new Country 
                        { 
                            Id = countryItem.i + 1, 
                            Label = countryItem.x.Label, 
                            Value = countryItem.x.Value 
                        }
                    );
                }
            }

            return countryList;
        }
    }
}
