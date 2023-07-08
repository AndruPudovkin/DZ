// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int [,] FillMatrix (int row, int col, int leftRang, int rightRang)
 {
    int [,] tempMatrix = new int[row, col];
    Random rend = new Random();
    for (int i = 0; i<tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j<tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i,j] = rend.Next(leftRang, rightRang+1);
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
int Fanction(int[,] fanMatrix)
{
    int[] sum = new int[fanMatrix.GetLength(0)];
    int max = sum[0];
    for (int i = 0; i<fanMatrix.GetLength(0); i++)
    {
        for (int j = 0; j<fanMatrix.GetLength(1); j++)
        {
           sum[i] =sum[i] + fanMatrix[i,j];
        }
    }
    for (int i=0; i<sum.Length; i++)
    {
        if (max<sum[i])
        {
            max = sum[i];
        }
    }
    return max;
}
//---------
int[,] matrix = FillMatrix(4, 9, 0, 4);
PrintMatrix(matrix);
int maxSum = Fanction(matrix);
System.Console.WriteLine("максимальная сумма = "+maxSum);
