// Домашнее задание к семинару 1

/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) Console.WriteLine($"The number '{number1}' is greatest than number '{number2}'");

else Console.WriteLine($"The number '{number2}' is greatest than number '{number1}'");




/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the therd number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxNum = number1;

if (maxNum < number2) maxNum = number2;
if (maxNum < number3) maxNum = number3;

Console.WriteLine("The maximum number is " + maxNum);




/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine($"The number '{number}' is even");
else Console.WriteLine($"The number '{number}' is not even");




/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current < number)
{
    if(current % 2 == 0) {
        Console.WriteLine(current);
    }
    current += 2;
}