namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class Country
{
    public long Id { get; set; }
    public string IsoCode { get; set; }
}