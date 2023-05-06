using System.Text.Json.Serialization;

#pragma warning disable CS8618

namespace Axial.Thunderstore.Models;

public class CommunityPackageList
{
    [JsonPropertyName("bg_image_src")]
    public string BgImageSrc { get; set; }
    
    [JsonPropertyName("categories")]
    public PackageCategory[] Categories { get; set; }
    
    [JsonPropertyName("community_name")]
    public string CommunityName { get; set; }
    
    [JsonPropertyName("has_more_pages")]
    public bool HasMorePages { get; set; }
    
    [JsonPropertyName("packages")]
    public PackageCard[] Packages { get; set; }
}