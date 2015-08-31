namespace Labo.RegexLibrary
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public static class RegexUtils
    {
        public static bool IsLetter(char c)
        {
            return Regex.IsMatch(c.ToString(CultureInfo.InvariantCulture), ToWholeWordPattern(Patterns.LETTER), RegexOptions.CultureInvariant | RegexOptions.Singleline);
        }

        public static bool IsWord(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            return Regex.IsMatch(value, ToWholeWordPattern(Patterns.WORD), RegexOptions.CultureInvariant | RegexOptions.Singleline);
        }

        public static bool IsIpAddress(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            return Regex.IsMatch(value, ToWholeWordPattern(Patterns.IP_ADDRESS), RegexOptions.CultureInvariant | RegexOptions.Singleline);
        }

        public static string ToWholeWordPattern(string pattern)
        {
            if (pattern == null)
            {
                throw new ArgumentNullException("pattern");
            }

            return "^" + pattern + "$";
        }
    }
}
