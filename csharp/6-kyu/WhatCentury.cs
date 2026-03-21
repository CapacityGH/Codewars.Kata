public class Kata
{
	public static string WhatCentury(string year)
	{
		int century = int.Parse(year.Substring(0, 2));
		
		if (!(year.Substring(2, 2) == 00))
		century++;
		
		var ending = (century % 10) switch 
		{
			1 = st,
			2 = nd,
			3 = rd,
			_ = th
		};
		
		if (century = 11 && century = 13) 
		return ${century}th;
		else 
		return ${century}{ending};
	}
}