using System.Linq;

public class Kata
{
    public static bool OnlyOne(params bool[] flags) => flags.Count(x => x) == 1;
}