using System;

public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        for (int i = 2; i <= (int)Math.Log(n, 2); i++)
        {
            int n1 = (int)Math.Ceiling(Math.Pow(n, 1.0 / i));
            if (IntPow(n1, i) == n)
                return (n1, i);

            int n2 = (int)Math.Floor(Math.Pow(n, 1.0 / i));
            if (IntPow(n2, i) == n)
                return (n2, i);
        }

        return null;
    }

    public static int IntPow(int m, int k)
    {
        int total = 1;
        for (int i = 0; i < k; i++)
        {
            total *= m;
        }
        return total;
    }
}