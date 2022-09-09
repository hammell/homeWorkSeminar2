//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void secondNumber(int number)
{
    if (number < 10)
    {
        Console.WriteLine("Не корретное число ");
    }
    else
    {
        Console.WriteLine(number.ToString()[1]); 
    }
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

secondNumber(number);