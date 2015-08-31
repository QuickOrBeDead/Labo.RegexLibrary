namespace Labo.RegexLibrary.Tests
{
    using System.Globalization;
    using System.Text.RegularExpressions;

    using NUnit.Framework;

    [TestFixture]
    public class PatternsFixture
    {
        [Test, Sequential]
        public void LettersWithHypen(
            [Values("a", "aa", "ab", "a-b", "a-a-b", "aa-abc-d", "a-", "a--b", "-", "--")]
            string value,
            [Values(true, true, true, true, true, true, false, false, false, false)]
            bool expectedResult)
        {
            Assert.AreEqual(expectedResult, IsMatch(value, Patterns.LETTERS_WITH_HYPHEN));
        }

        [Test]
        public void Byte()
        {
            for (byte i = 0; i < 255; i++)
            {
                string value = i.ToString(CultureInfo.InvariantCulture);
                Assert.AreEqual(true, IsMatch(value, Patterns.BYTE), value);
            }
        }

        [Test, Sequential]
        public void ByteValuesThatDoesNotMatch(
            [Values("00", "000", "001", "256", "500", "a", "")]
            string value)
        {
            Assert.AreEqual(false, IsMatch(value, Patterns.BYTE), value);
        }

        private static bool IsMatch(string value, string pattern)
        {
            return Regex.IsMatch(value, RegexUtils.ToWholeWordPattern(pattern), RegexOptions.CultureInvariant | RegexOptions.Singleline);
        }
    }
}
