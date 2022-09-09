void showWeekend(int a) //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
{
    if (a > 0 && a < 8)
    {
        if (a == 6 || a == 7)
        { Console.WriteLine("Выходной день"); }
        else { Console.WriteLine("Будний день"); }
    }
    else { Console.WriteLine("Не корректное число. В неделе 7 дней"); }
}
Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
showWeekend(number);