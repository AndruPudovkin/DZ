//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int Variables (string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
//
void Function(int k1, int b1, int k2, int b2, out int x, out int y)
{
    x = 0;
    y = 0;
    x = (b2-b1)/(k1-k2);
    y = k1*x+b1;
}
void Main()
{
    int k1 = Variables("Введите К1: ");
    int b1 = Variables("Введите B1: ");
    int k2 = Variables("Введите К2: ");
    int b2 = Variables("Введите B2: ");
    Function(k1, b1, k2, b2, out int x, out int y);
    System.Console.WriteLine($"Точка пересечения прямых имеет коардинаты ({x},{y})");
}
//----------------------------------------------------
Main();