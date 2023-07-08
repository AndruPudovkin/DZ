// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// int [,] FillMatrix (int row, int col, int leftRang, int rightRang)
//  {
//     int [,] tempMatrix = new int[row, col];
//     Random rend = new Random();
//     for (int i = 0; i<tempMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j<tempMatrix.GetLength(1); j++)
//         {
//             tempMatrix[i,j] = rend.Next(leftRang, rightRang+1);
//         }
//     }
// return tempMatrix;
//  }
int[,] FillMatrix (int row, int col)
 {
    int [,] tempMatrix = new int[row, col];
    //Random rend = new Random();
    for (int i = 0; i<tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j<tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i,j] = Convert.ToInt32(Console.ReadLine());
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
void Fanction(int[,] fanMatrix1, int[,] fanMatrix2)
{
    
     if (fanMatrix1.GetLength(0)==fanMatrix2.GetLength(1) )
     {
        int [,] fanMatrix = new int[fanMatrix1.GetLength(0), fanMatrix2.GetLength(1)];
        for (int i=0;  i<fanMatrix.GetLength(0); i++)
        {
            for(int j = 0;  j<fanMatrix.GetLength(1); j++)
            {
            int sum = 0;
              for (int k = 0; k<fanMatrix1.GetLength(1); k++)
              {
                sum = sum + fanMatrix1[i,k] * fanMatrix2[k,j];
              }
            fanMatrix[i,j] = sum;
            }
        }
    PrintMatrix(fanMatrix);
     }
     else
     {
        System.Console.WriteLine("not");
     }

}
//
int [,] matrix1 = FillMatrix(2,3 );
PrintMatrix(matrix1);
System.Console.WriteLine();
int [,] matrix2 = FillMatrix(3,2 );
PrintMatrix(matrix2);
System.Console.WriteLine();
Fanction(matrix1, matrix2);
