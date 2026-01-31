using System;
using System.Linq;
using System.Collections.Generic;

public class Brace 
{
    public static bool validBraces(string braces) 
    {
		var bracePairs = new Dictionary<char, char>()
		{
			{ '{', '}' },
			{ '[', ']' },
			{ '(', ')' }
		};

		if (braces.Length % 2 != 0)
			return false;

		var tracker = new Stack<char>();

		foreach (var currentBrace in braces)
		{
			// First symbol check (must be open brace)
			if (bracePairs.ContainsValue(currentBrace) && tracker.Count == 0)
				return false;

			// Pushing opening braces to the stack
			if (bracePairs.ContainsKey(currentBrace))
				tracker.Push(currentBrace);

			// Close brace
			else if (bracePairs.ContainsValue(currentBrace))
			{
				var previousOpenBrace = tracker.First();
				
				// Removing the last opening brace if it matches the current closing brace
				if (bracePairs[previousOpenBrace] == currentBrace)
					tracker.Pop();
				else
					return false;
			}

		}
		
		return tracker.Count == 0;  
  }
}