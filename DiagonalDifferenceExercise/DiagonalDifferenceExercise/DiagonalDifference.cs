namespace DiagonalDifferenceExercise;

// Given a square matrix, calculate the absolute difference between the sums of its diagonals.
public static class DiagonalDifference
{
    public static int Calculate(List<List<int>> arr)
    {
        int leftRightPosition = 0;
        int rightLeftPosition = arr.Count - 1;
        int sumLeftRight = 0;
        int sumRightLeft = 0;

        foreach (var list in arr)
        {
            sumLeftRight += list[leftRightPosition];
            leftRightPosition++;
        }

        foreach (var list in arr)
        {
            sumRightLeft += list[rightLeftPosition];
            rightLeftPosition--;
        }

        return Math.Abs(sumLeftRight - sumRightLeft);
    }
}
