// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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
void Fanction(int[,] fanMatrix, int m, int n)
{
    int count = 0;
    for (int i = 0; i < fanMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < fanMatrix.GetLength(1); j++)
        {
            if (i==m & j==n)
            {
               count++;
            }
        }    
    }
    if (count>0)
    {
        System.Console.WriteLine("Искомое число: " + fanMatrix[m,n]);
    }
    else
    {
        System.Console.WriteLine("такого числа нет");
    }
}
//
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}  
//-----------------------
int[,] matrix = FillMatrix(4, 4, 0, 10);
PrintMatrix(matrix);
int m = ReadInt("Введите номер строки ");
int n = ReadInt("Введите номер столбца ");
Fanction(matrix, m, n );