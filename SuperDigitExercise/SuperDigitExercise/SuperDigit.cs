using System.Numerics;

namespace SuperDigitExercise;

public static class SuperDigit
{
    // Given an integer, we need to find the super digit of the integer.
    // We define super digit of an integer x using the following rules: 
    // If x has only 1 digit, then its super digit is x.
    // Otherwise, the super digit of x is equal to the super digit of the sum of the digits of x. 

    public static int GetSuperDigit(string n, int k)
    {
        List<int> digits = new List<int>();
        long sum = 0;

        foreach (var digit in n)
        {
            digits.Add(int.Parse(digit.ToString()));
        }

        foreach (var num in digits)
        {
            sum += num;
        }

        sum *= k;

        if (sum > 9)
        {
            return GetSuperDigit(Convert.ToString(sum), 1);
        }

        return (int)sum;
    }
}
