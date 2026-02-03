using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  	public static bool IsIsogram(string str) 
  	{
      	str = str.ToLower();
    
     	HashSet<char> unique = new HashSet<char>();
      	foreach (var item in str)
     	{
     		unique.Add(item);
     	}
    
    	string result = string.Join("", unique);
      
		if (str == result)
    		return true;
     	return false;
 	 }
}