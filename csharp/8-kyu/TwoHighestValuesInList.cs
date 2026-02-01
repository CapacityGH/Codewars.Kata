using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static int[] TwoHighest(int[] arr)
    {
        List<int> uniqueArr = new List<int>(arr).Distinct().ToList();
        uniqueArr.Sort();
        uniqueArr.Reverse();

        if (uniqueArr.Count >= 2)
            return [uniqueArr[0], uniqueArr[1]];
        else if (uniqueArr.Count == 1)
            return [uniqueArr[0]];
        else
            return [];
    }
}
