/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Enter the number indicating the day of the week: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber>0 && dayNumber<8)  // проверка на соответсвие введенного числа дням недели
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("This day is a day off");  // если выходной
    }
    else
    {
        Console.WriteLine("This day is not a day off");  // если не выходной
    }
}
else
{
    Console.WriteLine("It's not a day of the week at all");  // если цифра не от 1 до 7
}