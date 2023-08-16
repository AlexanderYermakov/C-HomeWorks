// Домашняя работа по семинару 5

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        
    Console.WriteLine();
}

int Counting(int[] array)
{
    int quantity = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) 
            quantity += 1;       
    
    return quantity;
}

Console.WriteLine("Задайте длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int count = Counting(myArray);

WriteArray(myArray);

Console.WriteLine($"Количество четных чисел: {count} ");
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        
    Console.WriteLine();
}

int Checking(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
        sum += array[i];

    return sum;
}

Console.WriteLine("Задайте длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное число: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное число: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size, minValue, maxValue);

int sum = Checking(myArray);

WriteArray(myArray);

Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях в массиве: {sum} ");

/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/