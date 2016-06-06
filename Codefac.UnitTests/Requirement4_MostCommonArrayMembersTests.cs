using Codefac.Framework.Requirement4;
using NUnit.Framework;

namespace Codefac.UnitTests
{
    [TestFixture]
    public class Requirement4_MostCommonArrayMembersTests
    {
        [Test]
        [TestCase(new[] { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 }, new[] { 5, 4 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 1, 6, 7 }, new[] { 1 })]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7 }, new[] { 1, 2, 3, 4, 5, 6, 7 })]
        public void Requirement4_MostCommonMembersAreReturned(int[] inputArray, int[] outputArray)
        {
            Assert.AreEqual(outputArray, Requirement.MostCommonMembers(inputArray));
        }
    }
}
