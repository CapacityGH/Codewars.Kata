using System;
using System.Linq;

public class Persist
{
    public static int Persistence(long n)
    {
        int count = 0;

        var arr = n.ToString().Select(x => Convert.ToString(x)).ToArray();

        while (arr.Length > 1)
        {
            int prod = 1;

            foreach (var num in arr)
            {
                prod *= Convert.ToInt32(num);
            }

            arr = prod.ToString().Select(x => Convert.ToString(x)).ToArray();
            count += 1;
        }

        return count;
    }
}