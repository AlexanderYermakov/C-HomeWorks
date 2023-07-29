//Домашнее задание к семинару №3

/* Задача 19
Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да


bool CheckingNumber(int number)
{
    

}


Console.ReadLine()



Console.Write("Please input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

// 3113
int dig = num / 10;

while((dig % 10) == 0)
{
    int n1 = num % 10;
    
}

//int n1 = num % 10;

Console.WriteLine(dig);
Console.WriteLine(n1);
*/


/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double Distance3D(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double count = (xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA);
    return Math.Round(Math.Sqrt(count), 2);
}

Console.Write("Please enter the X coordinate for point A: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the Y coordinate for point A: ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the Z coordinate for point A: ");
double zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the X coordinate for point B: ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the Y coordinate for point B: ");
double yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the Z coordinate for point B: ");
double zB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Distance3D(xA, yA, zA, xB, yB, zB));

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

void CubeNumber(int n)
{
    int number = 1;
    while(number <= n)
    {
        Console.WriteLine($"{number} - {Math.Pow(number, 3)}");
        number++;
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num <= 0) Console.WriteLine("Uncorrect! Please input correct number");

CubeNumber(num);
*/