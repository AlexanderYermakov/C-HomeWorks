// Домашняя работа по семинару 5

/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] CreateArray(int size)     // Создание массива
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    
    return array;
}

void WriteArray(int[] array)    // Вывод заполненного массива на экран (для информации)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        
    Console.WriteLine();
}

int Counting(int[] array)       // Подсчет количества четных элементов
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


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateArray(int size, int minValue, int maxValue)     // Создание массива
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void WriteArray(int[] array)        // Вывод заполненного массива на экран (для информации)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        
    Console.WriteLine();
}

int Counting(int[] array)       // Подсчет суммы нечетных элементов
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

int sum = Counting(myArray);

WriteArray(myArray);

Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях в массиве: {sum} ");




/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] CreateArray(int size)  // Заполнение массива
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }  
    return array;
}

void WriteArray(double[] array)     // Вывод заполненного массива на экран (для информации)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        
    Console.WriteLine();
}

double DifferenceNumbers(double[] array)       // Определение минимального и максимального эл-ов, подсчет разницы
{
    double min = array[0];
    double max = array[0];
    double result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        if(array[i] < min) min = array[i];
    }
    result = max - min;
    return result;
}

Console.WriteLine("Задайте длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateArray(size);

double result =  DifferenceNumbers(myArray);

WriteArray(myArray);

Console.WriteLine($"Разница между минимальным и максимальным элементами = {result}");

