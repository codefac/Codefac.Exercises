using Codefac.Framework.Extensions;
using NUnit.Framework;

namespace Codefac.UnitTests
{
    [TestFixture]
    public class Requirement1_StringExtensionsTests
    {
        [Test]
        [TestCase(null, true)]
        [TestCase("a" , false)]
        [TestCase("", true)]
        [TestCase("null", false)]
        public void Requirement1_IsNullOrEmptyShouldReturnCorrectValueBasedOnInput(string input, bool returnValue)
        {
            Assert.AreEqual(returnValue, StringExtensions.IsNullOrEmpty(input));
        }
    }
}
