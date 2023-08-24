﻿// Домашнее задание к семинару 7

/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double [,] CreateArray2D(int rows, int columns, double minValue, double maxValue)
{
    double[,] array = new double[rows, columns];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Random rnd = new Random();
            double d = Math.Round(minValue + rnd.NextDouble() * (minValue + maxValue), 3); // Прописал округление до 3-го символа после зпт.
            array[i, j] = d;
            // возникли трудности с определением диапазона для Random.NextDouble подсказку для решения нагуглил и адаптировал к этой задаче
        }
            
    return array;

}

void ShowArray2D(double[,]array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");
        
        Console.WriteLine();
    }
}

Console.Write("Input a quantity of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a quantity of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible values: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a max possible values: ");
double max = Convert.ToDouble(Console.ReadLine());


double[,] myArray = CreateArray2D(rows, columns, min, max);
ShowArray2D(myArray);


/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/



/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
