namespace TellahLife.Extenstions
{
    public static class StringExtensions
    {
        public static string ConvertShortGuidToGuidString(this string shortGuid)
        {
            //the SMZ3 site uses slugid, which uses uuid to convert the seed's guid on single player seeds to a shorter, url friendly string
            //this does the necessary steps to reconvert.
            try
            {
                if (shortGuid?.Length == 22)
                    return Convert.ToHexString(Convert.FromBase64String(shortGuid.Replace("-", "+").Replace("_", "/") + "==")).ToLower();

                return shortGuid ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
