using FlippingMatrixExercise;

List<List<int>> matrix = new List<List<int>>
{
    new List<int> { 1, 2, 3, 4 },
    new List<int> { 5, 6, 100, 8 },
    new List<int> { 9, 10, 11, 12 },
    new List<int> { 13, 14, 15, 16 }
};

List<List<int>> matrix2 = new List<List<int>>
{
    new List<int> { 112, 42, 83, 119 },
    new List<int> { 56, 125, 56, 49 },
    new List<int> { 15, 78, 101, 43 },
    new List<int> { 62, 98, 114, 108 }
};

int val = FlippingMatrix.Calculate(matrix2);

Console.WriteLine(val);

Console.WriteLine("-------------------");
Console.WriteLine("matrix2[0][0]: " + matrix2[0][0]);
Console.WriteLine("matrix2[0][3]: " + matrix2[0][3]);
Console.WriteLine("matrix2[3][0]: " + matrix2[3][0]);
Console.WriteLine("matrix2[3][3]: " + matrix2[3][3]);
Console.WriteLine("-------------------");
Console.WriteLine("matrix2[0][1]: " + matrix2[0][1]);
Console.WriteLine("matrix2[0][2]: " + matrix2[0][2]);
Console.WriteLine("matrix2[3][1]: " + matrix2[3][1]);
Console.WriteLine("matrix2[3][2]: " + matrix2[3][2]);
Console.WriteLine("-------------------");
Console.WriteLine("matrix2[1][0]: " + matrix2[1][0]);
Console.WriteLine("matrix2[1][3]: " + matrix2[1][3]);
Console.WriteLine("matrix2[2][0]: " + matrix2[2][0]);
Console.WriteLine("matrix2[2][3]: " + matrix2[2][3]);
Console.WriteLine("-------------------");
Console.WriteLine("matrix2[1][1]: " + matrix2[1][1]);
Console.WriteLine("matrix2[1][2]: " + matrix2[1][2]);
Console.WriteLine("matrix2[2][1]: " + matrix2[2][1]);
Console.WriteLine("matrix2[2][2]: " + matrix2[2][2]);

//int n = matrix.Count;

//for (int i = 0; i < n / 2; i++)
//{
//    for (int j = 0; j < n / 2; j++)
//    {
//        //Console.WriteLine(matrix[i][j]); 
//        Console.WriteLine(matrix[i][n - 1 - j]); 
//        //Console.WriteLine(matrix[n - 1 - i][j]); 
//        //Console.WriteLine(matrix[n - 1 - i][n - 1 - j]); 

//    }
//}