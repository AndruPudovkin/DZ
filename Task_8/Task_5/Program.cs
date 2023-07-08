// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
int [,] FillMatrix ( ) // Понимаю решение не универсальное и не оптимальное, оно подходит только для масива 4х4 условию не противоречит (если есть этот коментарий, значит я не успел его оптимизировать, или не смог)
// хотелось бы увидеть более правильный вариант
    int count = 0;
    int [,] tempMatrix = new int[4, 4];
    for (int j = 0; j<tempMatrix.GetLength(0); j++)//идем по первой строке
    {
        count++;
            tempMatrix[0,j] = count;
    }
    for (int i = 1; i<tempMatrix.GetLength(0); i++)// идем по последнему столбцу
    {
        count++;
            tempMatrix[i, tempMatrix.GetLength(1)-1] = count;
    }
    for (int j = tempMatrix.GetLength(1)-2; j>=0 ; j--)// идем по последней строке
    {
        count++;
            tempMatrix[tempMatrix.GetLength(0)-1,j] = count;
    }
    for (int i = tempMatrix.GetLength(0)-2; i>=1; i--)//идем по первому столбцу
    {
        count++;
            tempMatrix[i, 0] = count;
    }
    for (int j = 1; j<tempMatrix.GetLength(0)-1; j++)//идем по второй строке
    {
        count++;
            tempMatrix[1,j] = count;
    }
     for (int i = 2; i<tempMatrix.GetLength(0)-1; i++)// идем по предпоследнему столбцу
    {
        count++;
            tempMatrix[i, tempMatrix.GetLength(1)-2] = count;
    }
     for (int j = 1; j>=1; j--)//идем по второй строке
    {
        count++;
            tempMatrix[tempMatrix.GetLength(0)-2,j] = count;
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
//-------
int[,] matrix = FillMatrix();
PrintMatrix(matrix);
