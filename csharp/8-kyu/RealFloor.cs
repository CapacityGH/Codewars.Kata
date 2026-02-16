using System;

public static class Kata
{
  	public static int GetRealFloor(int n)
  	{
    	if (n <= 0) return n;
    	if (n >= 14) return n - 2; 
    	return n - 1;
  	}
}