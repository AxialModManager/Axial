using System.Text.Json.Serialization;
#pragma warning disable CS8618

namespace Axial.Thunderstore.Models;

// ReSharper disable once ClassNeverInstantiated.Global
public class PackageCategory
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("slug")]
    public string Slug { get; set; }
}