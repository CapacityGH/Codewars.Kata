using System;
using System.Linq;

public class Solution
{
    public static string solve(string[] arr)
    {
        var times = arr.Select(TimeSpan.Parse).Distinct().OrderBy(t => t).ToArray();

        var maxGap = TimeSpan.Zero;

        for (int i = 1; i < times.Length; i++)
        {
            var gap = times[i] - times[i - 1] - TimeSpan.FromMinutes(1);

            if (gap > maxGap)
                maxGap = gap;
        }

        TimeSpan wrapGap = (times[0] + TimeSpan.FromHours(24)) - times[times.Length - 1] - TimeSpan.FromMinutes(1);
        if (wrapGap > maxGap)
            maxGap = wrapGap;

        return maxGap.ToString(@"hh\:mm");
    }
}
