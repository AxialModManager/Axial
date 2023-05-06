using System.Text.Json.Serialization;
#pragma warning disable CS8618

namespace Axial.Thunderstore.Models;

public class PackageCard
{
    [JsonPropertyName("categories")]
    public PackageCategory[] Categories { get; set; }
    
    [JsonPropertyName("community_name")]
    public string CommunityName { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    [JsonPropertyName("download_count")]
    public int DownloadCount { get; set; }
    
    [JsonPropertyName("image_src")]
    public string ImageSrc { get; set; }
    
    [JsonPropertyName("is_deprecated")]
    public bool IsDeprecated { get; set; }
    
    [JsonPropertyName("is_nsfw")]
    public bool IsNsfw { get; set; }
    
    [JsonPropertyName("is_pinned")]
    public bool IsPinned { get; set; }
    
    [JsonPropertyName("last_updated")]
    public DateTime LastUpdated { get; set; }
    
    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }
    
    [JsonPropertyName("package_name")]
    public string PackageName { get; set; }
    
    [JsonPropertyName("rating_score")]
    public int RatingScore { get; set; }
    
    [JsonPropertyName("team_name")]
    public string TeamName { get; set; }
}