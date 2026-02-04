using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static double Solution(int[] firstArray, int[] secondArray)
    {
        var nums = new List<double>();

        for (int i = 0; i < firstArray.Length; i++)
        {
            nums.Add((secondArray[i] - firstArray[i]) * (secondArray[i] - firstArray[i]));
        }

        return nums.Sum() / nums.Count;
    }
}