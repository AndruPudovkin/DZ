//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int A(int numM, int numN)
{
    if(numM==0) return numN+1;
    else if(numM > 0 && numN==0) return A(numM-1,1);
    else  return A(numM-1,A(numM,numN-1));
}
//----------------
int m = ReadInt("Введите петвое число ");
int n = ReadInt("Введите второе число ");
System.Console.WriteLine(A(m,n));