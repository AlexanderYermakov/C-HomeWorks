/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = (number / 10) % 10;
Console.WriteLine($"Second digit is {secondDigit}");




/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if((number / 100) == 0) Console.WriteLine("Therd digit is missing");
else 
{
    string therd = Convert.ToString(number);
    Console.WriteLine(therd[2]);
}



/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Enter the number of the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day == 6 || day == 7) Console.WriteLine("Congratulations! The day is a weekend!");
else Console.WriteLine("The day is not a weekend!");
