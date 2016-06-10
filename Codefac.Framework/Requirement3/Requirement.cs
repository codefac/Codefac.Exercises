using System;

namespace Codefac.Framework.Requirement3
{
    public static class Requirement
    {
        public static double GetArea(int sideA, int sideB, int sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new InvalidTriangleException();
            }
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new InvalidTriangleException();
            }
            double s = (double)(sideB + sideA + sideC)/2;
            return Math.Sqrt(s*(s - sideA)*(s - sideB)*(s - sideC));
        }
    }
}
