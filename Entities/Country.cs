namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class Country
{
    public long Id { get; set; }
    public string Label { get; set; }
    public string Value { get; set; }
}