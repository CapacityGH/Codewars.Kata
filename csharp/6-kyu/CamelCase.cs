using System;

public class Kata
{
	public static string ToCamelCase(string str)
	{
		string[] wordsArr = new string[3];
		wordsArr = str.Split(['_', '-']);
		
		string newStr = wordsArr[0];

		for (int i = 1; i < wordsArr.Length; i++)
		{
			string firstLetter = wordsArr[i].Substring(0, 1).ToUpper();
			string otherPart = wordsArr[i].Substring(1);
			newStr += firstLetter + otherPart;
		}
		
		return newStr;
	}
}