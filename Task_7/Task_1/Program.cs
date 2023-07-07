// . Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
//
double[,] FillMatrix (int m, int n, int leftRang, int rightRang)
{
    double [,] tempMatrix = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i<tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j<tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i,j] = Math.Round(rand.Next(leftRang,rightRang+1)+rand.NextDouble(),2);
        }
    }
return tempMatrix;    
}
//
void PrintMatrix(double[,] printMatrix)
{
    for (int i = 0; i<printMatrix.GetLength(0); i++)
    {
        for (int j = 0; j<printMatrix.GetLength(1); j++)
        {
            System.Console.Write(printMatrix[i,j]+"\t");
        }
        System.Console.WriteLine();
    }
}
//------------------------------------------------
int m = ReadInt("введите количество строк: ");
int n = ReadInt("введите количество столбцов: ");
double[,] matrix = FillMatrix(m,n,-10, 10);
PrintMatrix(matrix);