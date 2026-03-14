using System;
using FeInfo.Common.DTOs;

namespace TellahLife.Extenstions;

public static class TournamentRegistrantExtenstions
{
    public static string RegistrationDateLocal(this TournamentRegistrant registrant) => registrant.RegistrationDate.ToLocalTime().ToString("G");
}
