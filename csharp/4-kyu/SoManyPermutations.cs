using System;
using System.Collections.Generic;
using System.Linq;

class Permutations
{
    public static List<string> SinglePermutations(string s)
    {
        var result = new HashSet<string>();

        if (string.IsNullOrEmpty(s))
            return result.ToList();

        if (s.Length == 1)
        {
            result.Add(s);
            return result.ToList();
        }

        for (int i = 0; i < s.Length; i++)
        {
            var fixedLetter = s[i];
            var remainingLetters = s.Remove(i, 1);

            List<string> permutationsOfRemainingLetters = SinglePermutations(remainingLetters);

            foreach (var permutation in permutationsOfRemainingLetters)
                result.Add(fixedLetter + permutation);
        }

        return result.ToList();
    }
}