//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] FillArray(int size)
{
    int[] arrayfill = new int[size];
    for (int i =0; i < arrayfill.Length; i++)
    {
        arrayfill[i] = Convert.ToInt32(System.Console.ReadLine());
    }
return arrayfill;
}
//
void PrinArray(int[] arrayPrint)
{
    System.Console.WriteLine("[" + string.Join(",  ", arrayPrint) + "]");
}
//
int Function(int[] arrayfanction)
{
    int count = 0;
    for (int i =0; i < arrayfanction.Length; i++)
    {
        if (arrayfanction[i]>0)
        count++;
    }
return count;
}
//
void Main()
{
    System.Console.WriteLine("Введите число М: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] array = FillArray(m);
    PrinArray(array);
    int count = Function(array);
    System.Console.WriteLine(count);
}
//-------------------------------------------------
Main();