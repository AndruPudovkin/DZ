//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] arrayfill = new int[size];
    Random rand = new Random();
    for (int i =0; i < arrayfill.Length; i++)
    {
        arrayfill[i] = rand.Next(leftRange, rightRange+1);
    }
return arrayfill;
}
//
void PrinArray(int[] arrayPrint)
{
    System.Console.WriteLine("[" + string.Join(",", arrayPrint) + "]");
}
//
int  Function(int[] arrayfanction)
{
    int count = 0;
    for(int i = 0; i < arrayfanction.Length; i++)
    {
        if (arrayfanction[i] %2 ==0 )
        {
            count++;
        }
    }
return count;    
}
//
void Main()
{
    int[] array = FillArray(10, 100, 999);
    PrinArray (array);
    int result = Function(array);
    System.Console.WriteLine("Количество чётных чисел в массиве: " + result);
}
//-------------------------------------------------------------------
Main();