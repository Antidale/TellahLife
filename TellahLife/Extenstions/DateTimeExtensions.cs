using System;

namespace TellahLife.Extenstions;

public static class DateTimeExtensions
{
    public static string ToLocalString(this DateTimeOffset dateTimeOffset, string stringFormat = "G") => dateTimeOffset.ToLocalTime().ToString(stringFormat);

    public static string ToLocalString(this DateTime dateTime, string stringFormat = "G") => dateTime.ToLocalTime().ToString(stringFormat);
}
