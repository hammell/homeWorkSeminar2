void thirdNumber(int number) //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
{
    if (number < 100)
    {
        Console.WriteLine("Не корретное число ");
    }
    else
    {
        Console.WriteLine(number.ToString()[2]);
    }
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

thirdNumber(number);