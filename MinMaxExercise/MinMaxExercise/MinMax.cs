namespace MinMaxExercise;

// Given five positive integers, find the minimum and maximum values
// that can be calculated by summing exactly four of the five integers.
// Then print the respective minimum and maximum values as a single line
// of two space-separated long integers. 
public static class MinMax
{
    public static void MinMaxSum(List<long> arr)
    {
        if (arr.Any(val => val <= 0 || val > 1000000000))
            return;

        long min = arr.Min();
        long max = arr.Max();

        long sumMin = arr.Sum() - max;
        long sumMax = arr.Sum() - min;

        Console.WriteLine($"{sumMin} {sumMax}");
    }
}
