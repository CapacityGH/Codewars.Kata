using System;

public class Kata
{
    public static string Rot13(string message)
    {
        string result = "";

        foreach (char symbol in message)
        {
            if (Char.IsLetter(symbol))
            {
                if (Char.IsUpper(symbol))
                {
                    if (symbol >= 'N')
                        result += (char)(symbol - 13);
                    else
                        result += (char)(symbol + 13);
                }
                else
                {
                    if (symbol >= 'n')
                        result += (char)(symbol - 13);
                    else
                        result += (char)(symbol + 13);
                }
            }
            else
                result += symbol;
        }

        return result;
    }
}