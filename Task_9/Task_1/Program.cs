
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Sum(int numM, int numN)
{
    if(numM>numN) return 0;
    return numM+Sum(numM+1,numN);
}
//---------------------------
int m = ReadInt("Введите петвое число ");
int n = ReadInt("Введите второе число ");
if (n>m) 
{
    System.Console.WriteLine(Sum(m,n));
}
else
{
    System.Console.WriteLine(Sum(n,m));
}