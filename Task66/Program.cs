// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSum (int sum, int M, int N)
{
    while (M <= N)
    {
        sum+=M;
        GetSum(sum, M+=1,N);
    } 
    return sum;
}
int sum = 0;
Console.Write("M=1; N=8 -->");
Console.WriteLine(GetSum(sum,1,8));