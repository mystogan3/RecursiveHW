// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int GetResult( int m, int n) 
{
    if (m == 0) return n + 1;
    if (n == 0) return GetResult(m - 1, 1);
    return GetResult(m - 1, GetResult(m, n - 1));
}

Console.Write("m = 3, n = 2 --> ");
Console.WriteLine($"A(3,2) = {GetResult(3,2)}");

