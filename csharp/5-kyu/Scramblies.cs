using System;
using System.Collections.Generic;

public class Scramblies
{
    public static bool Scramble(string str1, string str2)
    {
        var dict = new Dictionary<char, int>();

        foreach (var item in str1)
        {
            if (!dict.ContainsKey(item))
                dict[item] = 1;
            else
                dict[item]++;
        }

        foreach (var item in str2)
        {
            if (!dict.ContainsKey(item) || dict[item] == 0)
                return false;
            else
                dict[item]--;
        }
        return true;
    }
}