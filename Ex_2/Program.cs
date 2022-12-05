// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int FindSum(int m, int n)
{
    int sum = 0;
    if(m <= n)
    {
        sum += m + FindSum(m + 1, n);
        return sum;
    }
    return sum;
}
Console.WriteLine(FindSum(2, 6));