using System;
using System.Collections.Generic;

public class Deadfish
{
    public static int[] Parse(string data)
    {
        var result = new List<int>();
        int number = 0;

        foreach (char c in data)
        {
            switch (c)
            {
                case 'i':
                    number++;
                    break;
                case 'd':
                    number--;
                    break;
                case 's':
                    number *= number;
                    break;
                case 'o':
                    result.Add(number);
                    break;
            }
        }

        return result.ToArray();
    }
}