using FeInfo.Common.DTOs;
using TellahLife.Services;

namespace TellahLife.Features.RaceSearch;

public interface IRaceState
{
    IEnumerable<RaceDetail> Races { get; }

    Task GetRaces(string flagset = "", string description = "");
}


public class RaceState(IFeApiDataService dataService) : IRaceState
{
    public IEnumerable<RaceDetail> Races { get; private set; } = [];
    private Dictionary<int, string> _seedHtml { get; set; } = [];

    public async Task GetRaces(string flagset = "", string description = "")
    {
        Races = await dataService.GetRacesAsync(flagset, description);
    }

    // public async Task<string> FetchSeedHtml(int id)
    // {
    //     if(!)
    // }
}
