/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int number, secondDigit;
Console.Write("Enter three-digit number... ");
number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)  // проверка на трехзначность числа
{                                   // производимые действия, если число трехзначное
    secondDigit = (number - ((number/100)*100))/10; // определение второй цифре в числе
    Console.Write("Second digit - ");
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("Wrong number"); // сообщение в случае, если введенное число не трехзнначное
}