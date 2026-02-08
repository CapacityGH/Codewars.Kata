using System;
using System.Linq;

namespace Solution
{
    public static class Program
    {
        public static int binToDec(string s)
        {
            s = new string(s.Reverse().ToArray());

            int total = 0;
            int num = 1;

            for (int i = 0; i < s.Length; i++)
            {
                int bit = s[i] - '0';
                total += bit * num;
                num *= 2;
            }

            return total;
        }
    }
}