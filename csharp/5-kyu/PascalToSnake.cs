using System;
using System.Text;

public static class Kata 
	{
	public static string ToUnderscore(int str) => str.ToString();

	public static string ToUnderscore(string str) 
	{
		if (string.IsNullOrEmpty(str)) return str;
		
		var result = new StringBuilder();
		
		for (int i = 0; i < str.Length; i++) 
		{
			if (char.IsUpper(str[i]) && i > 0) 
				result.Append("_");
			
			result.Append(Char.ToLower(str[i]));  
		}
		
		return result.ToString();
	}
	}


// using System;
// using System.Collections.Generic;
// using System.Text;

// public static class Kata 
// {
// public static string ToUnderscore(int str) => str.ToString();

// public static string ToUnderscore(string str) 
// {
// 	if (str.Length == 0) return null;
	
// 	var arr = new List<string>();
	
// 	var currentWord = new StringBuilder();
	
// 	for (int i = 0; i < str.Length; i++) 
// 	{
// 		if (char.IsUpper(str[i]) && currentWord.Length > 0) 
// 		{
// 			arr.Add(currentWord.ToString());
// 			currentWord.Clear();
// 			currentWord.Append(Char.ToLower(str[i]));
// 		}  
// 		else
// 			currentWord.Append(Char.ToLower(str[i]));  
// 	}
	
// 	arr.Add(currentWord.ToString());
	
// 	return string.Join("_", arr);
// }
// }