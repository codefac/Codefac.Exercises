using Codefac.Framework.Extensions;
using NUnit.Framework;

namespace Codefac.UnitTests
{
    [TestFixture]
    public class Requirement2_DivisorsSequenceTests
    {
        [Test]
        [TestCase(60, new[] { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 })]
        [TestCase(42, new[] { 1, 2, 3, 6, 7, 14, 21, 42 })]
        public void Requirement2_DivisorsSequenceIsCorrectlyGenerated(int integer, int[] sequence)
        {
            Assert.AreEqual(sequence, integer.GenerateDivisorSequence());
        }
    }
}
