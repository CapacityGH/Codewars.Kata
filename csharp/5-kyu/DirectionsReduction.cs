using System;
using System.Collections.Generic;

public class DirReduction
{

    public static string[] dirReduc(String[] dir)
    {
        var newDir = new List<string>();

        for (int i = 0; i < dir.Length; i++)
        {
            if (newDir.Count == 0)
            {
                newDir.Add(dir[i]);
                continue;
            }

            string current = dir[i];
            string last = newDir[newDir.Count - 1];

            bool isOpposite = (last == "NORTH" && current == "SOUTH")
                              || (last == "SOUTH" && current == "NORTH")
                              || (last == "EAST" && current == "WEST")
                              || (last == "WEST" && current == "EAST");

            if (isOpposite)
                newDir.RemoveAt(newDir.Count - 1);
            else
                newDir.Add(current);
        }

        return newDir.ToArray();
    }
}