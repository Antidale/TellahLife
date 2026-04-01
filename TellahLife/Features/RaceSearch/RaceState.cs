using FeInfo.Common.DTOs;
using TellahLife.Services;

namespace TellahLife.Features.RaceSearch;

public class RaceState(IFeApiDataService dataService)
{
    public HashSet<RaceDetail> Races { get; private set; } = [];
}
