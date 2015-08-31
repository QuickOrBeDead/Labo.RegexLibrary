namespace Labo.RegexLibrary.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class RegexUtilsFixture
    {
        [Test]
        public void IsLetter()
        {
            char c;
            for (int i = 'a'; i <= 'z'; i++)
            {
                c = (char)i;
                Assert.AreEqual(true, RegexUtils.IsLetter(c), c.ToString());
            }

            for (int i = 'A'; i <= 'Z'; i++)
            {
                c = (char)i;
                Assert.AreEqual(true, RegexUtils.IsLetter(c), c.ToString());
            }

            const string nonLetters = "0123456789!'^+%&/()=?*>£#$½{[]}\\ÅÄÖåäöéÉóÓüÜïÏôÔğĞıİşŞçÇöÖ";

            for (int i = 0; i < nonLetters.Length; i++)
            {
                c = nonLetters[i];
                Assert.AreEqual(false, RegexUtils.IsLetter(c), c.ToString());
            }
        }

        [Test, Sequential]
        public void IsWord(
            [Values("a", "any", "Mike's", "I'm", "O'Reilly", "seein'", "hard-code", "start-of-line", "hard-code's", "start-of-line's", "1", "a ", "a sentence")]
            string value,
            [Values(true, true, true, true, true, true, true, true, true, true, false, false, false)]
            bool expectedResult)
        {
            Assert.AreEqual(expectedResult, RegexUtils.IsWord(value));
        }

        [Test, Sequential]
        public void IsIpAddress(
            [Values("0.0.0.0", "127.0.0.1", "255.255.255.255", "192.168.1.1", "10.10.10.10", "255.0.0.0", "0.255.0.0", "1.1.1.1", "99.99.99.99", "100.100.100.100", "055.055.055.055", "1.1.1", "255.10.10.01")]
            string value,
            [Values(true, true, true, true, true, true, true, true, true, true, false, false, false)]
            bool expectedResult)
        {
            Assert.AreEqual(expectedResult, RegexUtils.IsIpAddress(value));
        }
    }
}
