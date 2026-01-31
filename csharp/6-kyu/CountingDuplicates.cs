using System;
using System.Linq;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        return str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
    }
}