// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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
int Function(int[] arrayfanction)
{
    int sum = 0;
    for (int i = 1; i < arrayfanction.Length; i += 2)
    {
            sum = sum + arrayfanction[i];
    }
return sum;
}
//
void Main()
{
    int[] array = FillArray(6, -30, 30);
    PrinArray(array);
    int result = Function(array);
    System.Console.WriteLine("Сумму элементов, стоящих на нечётных позициях: " + result);
}
//----------------------------------------------------------------------------------------
Main();