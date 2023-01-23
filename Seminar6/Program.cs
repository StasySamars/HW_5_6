/* Задача 49: Задайте двумерный массив. Найдите элементы,
 у которых оба индекса чётные,
 и замените эти элементы на их квадраты. */
/* Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
        
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] SquarePositivePlaces (int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0) {
                array[i,j]=array[i,j]*array[i,j];
            }
        }
    }
    return array;
}
Console.WriteLine("Измененный массив, где элементы с положительными индексами - квадрат: ");
SquarePositivePlaces (array);
PrintArray(array); */









/* Задача 51: Задайте двумерный массив. Найдите сумму элементов,
 находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
 */
 /* Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
             result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
        
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
int SquarePositivePlaces (int[,] inArray)
{
    int sum=0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i==j)
            {
                sum =sum + inArray[i,j];
            } 
        }
    }
    return sum;
}
Console.WriteLine($"Сумма элементов массива, стоящих на диагонали: {SquarePositivePlaces(array)}");

 */







/* Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
 */
/* Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 4);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i+j;
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
} */


//Таблица умножения

/* Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9");
Console.Write("--------------------------------------------------------------------------");
Console.WriteLine();
for (int i = 1; i < 10; i++)
{
     Console.Write(i + "   |  ");
     for (int j = 1; j < 10; j++)
    {
     Console.Write("\t"+i*j);
    }
    Console.WriteLine("");
    Console.WriteLine("");
}
Console.ReadLine(); */

