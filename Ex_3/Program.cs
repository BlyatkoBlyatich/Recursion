// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int num1, int num2)
{
    if(num1 == 0)
    {
       return num2 + 1;
    }
    if(num1 > 0 && num2 == 0)
    {
       return Akkerman(num1 - 1, 1);
    }
    if(num1 > 0 && num2 > 0)
    {
       return Akkerman(num1 - 1, Akkerman(num1, num2 - 1));
    }
    else return num1 + 1;
}

Console.WriteLine(Akkerman(2,2));