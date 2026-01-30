using System;
using System.Collections.Generic;

public class RomanDecode
{
    public static int Solution(string roman)
    {
        roman = roman.Replace(" ", "");

        var nums = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 }
        };

        int total = 0;

        for (int i = 0; i < roman.Length; i++)
        {
            int current = nums[roman[i].ToString()];
            int next = i + 1 < roman.Length ? nums[roman[i + 1].ToString()] : 0;

            if (current < next)
            {
                total += next - current;
                i++;
            }
            else
                total += current;
        }

        return total;
    }
}