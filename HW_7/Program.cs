/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns, -10, 10);
PrintArray(array);
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f3} ");
        }
        Console.WriteLine();
    }
}
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return result;
}


/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */


Console.Clear();
Console.Write("From which row (1-5) you need value?  ");
int row = int.Parse(Console.ReadLine());

Console.Write("From which column(1-5) you need value?  ");
int column = int.Parse(Console.ReadLine());

double[,] array = GetArray(5, 5, -10, 10);
Console.WriteLine();
Console.WriteLine("Your random array is: ");
PrintArray(array);
Console.WriteLine();
DesiredValue(array);
void DesiredValue(double[,] inArray)
{
    if (row > inArray.GetLength(0) || column > inArray.GetLength(1))
    {
        Console.WriteLine($"Out of array's size. Try again!");
    }
    else
    {
        Console.Write($"Your desired value is {array[row - 1, column - 1]:f2}");
    }
}


void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f2}\t");
        }
        Console.WriteLine();
    }
}
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
            if (result[i, j] > maxValue) result[i, j] = maxValue;
        }
    }
    return result;
} 











/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


Console.Clear();
int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
Console.WriteLine();
ArithmeticMean(array);

void ArithmeticMean(int[,] array)
{
    Console.WriteLine("Your Arithmetic mean of each column: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0):f2} | ");
    }
}
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[new Random().Next(1, 10), new Random().Next(1, 10)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Amount of values in each column is: {array.GetLength(0)}");
}