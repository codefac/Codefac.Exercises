using System;
using System.Collections.Generic;
using System.Linq;

namespace Codefac.Framework.Requirement4
{
    public static class Requirement
    {
        public static IEnumerable<int> MostCommonMembers(int[] input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            if(input.Length == 0)
                return new int[0];
            var groups = input.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();
            return groups.Where(e => e.Count() == largest.Count()).Select(e => e.Key);
        }
    }
}
