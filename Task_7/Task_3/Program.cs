// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int [,] FillMatrix(int row, int col, int leftRang, int rightRang)
{
    int[,] tempMatrix = new int[row, col];
    Random rend = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for(int j = 0; j<tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rend.Next(leftRang, rightRang+1);
        }
    }
return tempMatrix;
}
//
void PrintMatrix(int[,] printMatrix)
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
//
double [] Fanction(int [,] fanMatrix)
{
    double[] array = new double[fanMatrix.GetLength(0)];
    int sum = 0;
    int count = 0;
    for (int i = 0; i<fanMatrix.GetLength(0); i++)
    {
        for (int j = 0; j<fanMatrix.GetLength(1); j++)
        {
           sum = sum + fanMatrix[i,j];
           count++;
        }
        array[i] = sum/count;
    }
return array;
}
//
void PrintArray(double[] arrayPrint)
{
     System.Console.WriteLine("[" + string.Join(",  ", arrayPrint) + "]");
}
//------------------------------------
int[,] matrix = FillMatrix(10, 6, 0, 100);
PrintMatrix(matrix);
double[] array = Fanction(matrix);
PrintArray(array);