using System;

public static class Calculator
{
	public static double Execute(double num1, char op, double num2)
	{
		return op switch 
		{
			'+' => num1 + num2,
			'-' => num1 - num2,
			'*' => num1 * num2,
			'/' => num2 != 0 ? num1 / num2 : throw new ArgumentException("Zero Division is not allowed"),
			_ => throw new ArgumentException("The string is not one of the specified characters")
		};
	}
}