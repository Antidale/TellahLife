using FeInfo.Common.DTOs;
using TellahLife.Services;

namespace TellahLife.Features.SeedSeach;

public class SeedsState(IFeApiDataService dataService)
{
    public HashSet<SeedDetail> Seeds { get; private set; } = [];
    private Dictionary<int, string> _seedHtml { get; set; } = [];

    public async Task GetSeeds(string binaryFlags = "", string flagName = "", string seedValue = "")
    {
        var seeds = await dataService.GetSeedsAsync(binaryFlags: binaryFlags, flagName: flagName, seedValue: seedValue);
        foreach (var seed in seeds)
        {
            Seeds.Add(seed);
        }
    }

    public async Task<string> FetchSeedHtml(int id)
    {
        if (!Seeds.Any(x => x.SeedId == id))
        {
            var seed = await dataService.GetSeedByIdAsync(id);

            if (seed is not null)
                Seeds.Add(seed);
            else
                return string.Empty;
        }

        if (_seedHtml.ContainsKey(id))
        {
            return _seedHtml[id];
        }

        _seedHtml.TryGetValue(id, out var html);

        if (!string.IsNullOrEmpty(html))
            return html;

        try
        {
            html = await dataService.GetSeedHtmlAsync(id);

            if (!string.IsNullOrEmpty(html))
            {
                _seedHtml.TryAdd(id, html);
            }
        }
        catch
        {
            //
        }


        return html ?? string.Empty;
    }
}
