using System.Text;

public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        var phone = new StringBuilder("(");
        for (int i = 0; i < numbers.Length; i++)
        {
            phone.Append(numbers[i]);
            if (i == 2)
                phone.Append(") ");
            if (i == 5)
                phone.Append("-");
        }

        return phone.ToString();
    }
}