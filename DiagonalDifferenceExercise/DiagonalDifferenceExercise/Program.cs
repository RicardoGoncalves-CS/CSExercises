using DiagonalDifferenceExercise;

List<List<int>> matrix = new List<List<int>>
{
    new List<int>{ 3, 5, 7, 9 },
    new List<int>{ 0, 1, 3, 1 },
    new List<int>{ 6, 1, 7, 9 },
    new List<int>{ 4, 5, 8, 2 },
};

// Left-Right diagonal: 3 + 1 + 7 + 2 = 13
// Right-Left diagonal: 9 + 3 + 1 + 4 = 17
// | 13 - 17 | = 4

Console.WriteLine(DiagonalDifference.Calculate(matrix));