namespace FlippingMatrixExercise;

public static class FlippingMatrix
{
    public static int Calculate(List<List<int>> matrix)
    {
        int n = matrix.Count;
        int maxSum = 0;
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                int maxElement = Math.Max(matrix[i][j], matrix[i][n - j - 1]);
                maxElement = Math.Max(maxElement, matrix[n - i - 1][j]);
                maxElement = Math.Max(maxElement, matrix[n - i - 1][n - j - 1]);
                maxSum += maxElement;
            }
        }

        return maxSum;
    }
}