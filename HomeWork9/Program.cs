/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

string PrintNumbers(int n)
{
    string lastNumber = "1";
    if(n == 1) return lastNumber;
    return (n + " " + PrintNumbers(n - 1));
}

Console.Write("Input a start integer number: ");
int startNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(startNumber));




/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumNumbers(int m, int n)
{
    int iterator = m;
    int sum = 0;

    if(iterator > n) return sum;
    return sum = m + (SumNumbers(m + 1, n));    
}

Console.Write("Input a first integer number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second integer number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbers(firstNumber, secondNumber));




/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int AckermanFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
            return AckermanFunction(n - 1, 1);
        else
            return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}

Console.Write("Input a first integer number for Ackerman function: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second integer number for Ackerman function: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AckermanFunction(firstNumber, secondNumber));