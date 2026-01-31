using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            var numbersCount = new Dictionary<int, int>();

            // Count occurrences of each number in the array
            foreach (var number in seq)
            {
                if (!numbersCount.ContainsKey(number))
                    numbersCount.Add(number, 1);
                else
                    numbersCount[number] += 1;
            }

            // Find and return the number that appears an odd number of times
            foreach (var pair in numbersCount)
            {
                if (pair.Value % 2 == 1)
                    return pair.Key;
            }
            return -1;

            // Shorter approach
            // return seq.GroupBy(x => x).Single(x => x.Count() % 2 == 1).Key;
        }

    }
}