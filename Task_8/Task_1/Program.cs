// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] FillMatrix(int row, int col, int leftRang, int rightRang)
{
    int[,] tempMatrix = new int[row, col];
    Random rend = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rend.Next(leftRang, rightRang + 1);
        }
    }
    return tempMatrix;
}

//
void PrintMatrix(int[,] printMatrix)
{
    for (int i = 0; i < printMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < printMatrix.GetLength(1); j++)
        {
            System.Console.Write(printMatrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

//
int[,] Fanction(int[,] fanMatrix)
{
    for (int i = 0; i < fanMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fanMatrix.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < fanMatrix.GetLength(1) - 1; z++)
            {
                if (fanMatrix[i, z] < fanMatrix[i, z + 1]) 
                {
                    int temp = 0;
                    temp = fanMatrix[i, z];
                    fanMatrix[i, z] = fanMatrix[i, z + 1];
                    fanMatrix[i, z + 1] = temp;
                }
            }
        }
    }

    return fanMatrix;
}

//
int[,] matrix = FillMatrix(4, 4, 0, 100);
PrintMatrix(matrix);
System.Console.WriteLine();
int[,] new_matrix = Fanction(matrix);
PrintMatrix(new_matrix);
