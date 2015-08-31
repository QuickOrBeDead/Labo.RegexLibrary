namespace Labo.RegexLibrary
{
    public static class Patterns
    {
        public const string LETTER = "[a-zA-Z]";

        public const string LETTERS = LETTER + "+";

        public const string LETTERS_WITH_HYPHEN = "(" + LETTERS + "-?" + LETTER + "*" + ")*" + LETTERS;

        public const string WORD = LETTERS_WITH_HYPHEN + "'?" + LETTER + "*";

        public const string DIGIT = "[0-9]";

        public const string DIGITS = DIGIT + "+";

        public const string BYTE = "(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])";

        public const string IP_ADDRESS = BYTE + "." + BYTE + "." + BYTE + "." + BYTE;

        public const string INTEGER = DIGITS;

        // Email
        // Url
        // Phone number
        // Date
        // Time
        // Date / Time
    }
}
