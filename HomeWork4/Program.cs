/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// void ExpNumber(int a, int b)
// {
//     int res = 1;
//     int i = 1;
//     while(i <= b)
//     {
//         res *= a;    
//         i++;
//     }
//     Console.WriteLine(res);
// }


// Console.WriteLine("Input a number A: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input a number B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// // Проверка на отрицательную степень
// if(b < 0) Console.WriteLine("Please enter positive number");
// else ExpNumber(a, b);




/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// int SumDigits(int number)
// {
//     int result = 0;
//     while(number > 0)
//     {
//         result += number % 10; 
//         number = number / 10;
//     }
//     return result;
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма всех чисел в цифре {number} составляет {SumDigits(number)}");


/* Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/