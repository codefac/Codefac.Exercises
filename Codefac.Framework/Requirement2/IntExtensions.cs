using System;
using System.Collections.Generic;
using System.Linq;

namespace Codefac.Framework.Extensions
{
    public static class IntExtensions
    {
        public static IEnumerable<int> GenerateDivisorSequence(this int value)
        {
            var listA = new List<int>();
            var listB = new List<int>();
            for (var i = 1; i <= Math.Floor(Math.Sqrt(value)); i++)
            {
                if (value % i == 0)
                {
                    listA.Add(i);
                    listB.Add(value / i);
                }
            }
            listB.Reverse();
            if(listB[0] == listA[listA.Count-1])
                listB.RemoveAt(0);
            return listA.Concat(listB);
        }
    }
        
}
