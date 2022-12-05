// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int Numbers(int number)
{
    if(number > 0) 
    {
        Console.WriteLine(number);
        Numbers(number -= 1);
    }
    return number;
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Numbers(num);
