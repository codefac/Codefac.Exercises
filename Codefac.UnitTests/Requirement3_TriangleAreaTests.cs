using Codefac.Framework.Requirement3;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefac.UnitTests
{
    [TestFixture]
    public class Requirement3_TriangleAreaTests
    {
        [Test]
        [TestCase(6, 3, 4, 5)]
        [TestCase(1.984313483298443d, 2, 2, 3)]
        public void Requirement3_ValidTriangleInputsReturnValidArea(double expectedArea, double sideA, double sideB, double sideC)
        {
            Assert.AreEqual(expectedArea, Requirement.GetArea(sideA,sideB,sideC));
        }

        [Test]
        [TestCase(-1, 2 ,3)]
        [TestCase( 1, 2, 3)]
        public void Requirement3_InvalidInputsThrowSpecificException(int sideA, int sideB, int sideC )
        {
            Assert.Throws<InvalidTriangleException>(()=> Requirement.GetArea(sideA, sideB, sideC));
        }
    }
}
