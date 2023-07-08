// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] FillArray(int leftRang, int rightRang)
{
    int[,,] array = new int[2,2,2];
    Random rend = new Random();
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            for (int k = 0; k<array.GetLength(2); k++)
            {
                array[i,j,k] = rend.Next(leftRang, rightRang);
            }
        }
    }
return array;
}
//
void PrintArray(int[,,] arrayP)
{
    for (int i = 0; i<arrayP.GetLength(0); i++)
    {
        for (int j = 0; j<arrayP.GetLength(1); j++)
        {
            for (int k = 0; k<arrayP.GetLength(2); k++)
            {
                System.Console.Write($"{arrayP[i,j,k]} ({i},{j},{k})"+"\t");
            }
        }
    }
}
//-----------------------
int[,,] array = FillArray(0, 10);
PrintArray(array);
