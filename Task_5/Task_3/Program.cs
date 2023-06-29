// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] FillArray(int size, int leftRange, int rightRange)
{
    double[] arrayfill = new double[size];
    Random rand = new Random();
    for (int i =0; i < arrayfill.Length; i++)
    {
        arrayfill[i] = Math.Round(rand.Next(leftRange, rightRange+1)+rand.NextDouble(),2);
    }
return arrayfill;
}
//
void PrinArray(double[] arrayPrint)
{
    System.Console.WriteLine("[" + string.Join(",  ", arrayPrint) + "]");
}
//
void Function(double[] arrayfanction)
{
    double max = 0;
    double min = 0;
    double result = 0;
    min = arrayfanction.Min();
    max = arrayfanction.Max();
    result = max - min;
    System.Console.WriteLine($"Разница между нмаксимальным числом в массиве ({max}) и минимальным числом ({min}): {result}");
}
//
void Main()
{
    double [] array = FillArray(5, 0, 10);
    PrinArray(array);
    Function(array);
}
//------------------------------------
Main();


