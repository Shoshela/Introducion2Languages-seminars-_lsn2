// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  645 -> 5
//  78 -> третьей цифры нет
//  2679 -> 6

Console.Write("Enter number... ");
string stringNumber = Console.ReadLine();
if (stringNumber.Length > 2)
{
  Console.WriteLine("Third digit - " + stringNumber[2]);
}
else 
{
  Console.WriteLine("... There is no third digit");
}