using System;
using System.Collections.Generic;

public static class Kata
{
    public static string Disemvowel(string str)
    {
        if (string.IsNullOrEmpty(str))
            return "";

        List<string> vowels = ["a", "e", "i", "o", "u", "A", "E", "I", "O", "U"];
        List<string> newStr = new();

        foreach (var item in str)
        {
            if (!vowels.Contains(item.ToString()))
                newStr.Add(item.ToString());
        }

        return string.Join("", newStr);
    }
}