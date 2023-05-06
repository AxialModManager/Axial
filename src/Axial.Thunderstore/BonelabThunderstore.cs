using System.Net.Http.Headers;
using System.Text.Json;
using Axial.Thunderstore.Models;

namespace Axial.Thunderstore;

public class BonelabThunderstore
{
    private const string _community = "bonelab";
    private const string _baseUrl = "https://bonelab.thunderstore.io/";

    private readonly HttpClient _client;
    
    public BonelabThunderstore()
    {
        _client = new HttpClient()
        {
            BaseAddress = new Uri(_baseUrl),
        };
    }

    public async Task<CommunityPackageList?> GetFrontendPackages(string communityIdentifier = _community)
    {
        var request = new HttpRequestMessage(HttpMethod.Get,
            $"/api/experimental/frontend/c/{communityIdentifier}/packages/");
        request.Headers.UserAgent.Add(new ProductInfoHeaderValue(nameof(Axial), "0.0.0"));

        var response = await _client.SendAsync(request);
        if (!response.IsSuccessStatusCode) return null;

        var json = await response.Content.ReadAsStreamAsync();
        var communityPackageList = await JsonSerializer.DeserializeAsync<CommunityPackageList>(json);
        return communityPackageList;
    }
}