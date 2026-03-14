using FeInfo.Common.DTOs;

namespace TellahLife.Extenstions;

public static class TournamentSummaryExtenstions
{
    public static bool HasRulesLink(this TournamentSummary summary) => !string.IsNullOrWhiteSpace(summary.RulesLink);
    public static bool HasStandingsLink(this TournamentSummary summary) => !string.IsNullOrWhiteSpace(summary.StandingsLink);

    public static string RegistrationStatus(this TournamentSummary summary)
    {
        if (DateTimeOffset.UtcNow < summary.RegistrationStart) return $"Registration Opens {summary.RegistrationStart.ToLocalString()}";

        if (DateTimeOffset.UtcNow > summary.RegistrationEnd) return "Registration Closed";

        return "Registration Open";
    }

    public static bool HasOpenedRegistration(this TournamentSummary summary) => !summary.RegistrationStatus().StartsWith("Registration Opens");

}
