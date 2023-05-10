namespace PlusMinusExercise;

// Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.
// Print the decimal value of each fraction on a new line with 6 places after the decimal.

public static class PlusMinus
{
    public static void FindFractions(List<int> arr)
    {
        decimal positiveCount = 0;
        decimal negativeCount = 0;
        decimal zeroCount = 0;

        foreach (var num in arr)
        {
            if (num < 0)
                negativeCount++;
            else if (num > 0)
                positiveCount++;
            else
                zeroCount++;
        }

        decimal positiveFraction = positiveCount / (decimal)arr.Count;
        decimal negativeFraction = negativeCount / (decimal)arr.Count;
        decimal zeroFraction = zeroCount / (decimal)arr.Count;

        Console.WriteLine(positiveFraction.ToString("F6"));
        Console.WriteLine(negativeFraction.ToString("F6"));
        Console.WriteLine(zeroFraction.ToString("F6"));
    }
}
