// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 

//В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/* int[,] GenerateArray(int rows, int columns, int minVal, int maxVal)
{
    int[,] result = new int[rows, columns];
    for (int i=0;i<rows;i++)
    {
        for (int j=0;j<columns;j++)
        {
            result[i,j] = new Random().Next(minVal, maxVal+1);
        }
    }
    return result;
}

void PrintArray(int[,] table)
{
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortArrayRows(int[,] table)
{
    int minPosition, tmpVal;
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            minPosition = j;
            for (int k=j+1;k<table.GetLength(1);k++)
            {
                if (table[i,k] > table[i, minPosition])
                {
                    tmpVal = table[i,j];
                    table[i,j] = table[i, k];
                    table[i, k] = tmpVal;
                }
            }
        }
    }
}

int[,] myArr = GenerateArray(3, 4, 0, 10);

Console.WriteLine("Сгенерирован массив");
PrintArray(myArr);
SortArrayRows(myArr);
Console.WriteLine("После сортировки по строкам массив выглядит");
PrintArray(myArr); */








// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/* int[,] GenerateArray(int rows, int columns, int minVal, int maxVal)
{
    int[,] result = new int[rows, columns];
    for (int i=0;i<rows;i++)
    {
        for (int j=0;j<columns;j++)
        {
            result[i,j] = new Random().Next(minVal, maxVal+1);
        }
    }
    return result;
}

void PrintArray(int[,] table)
{
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

int CountRowElementsSum(int[,] table, int row)
{
    int result = 0;
    for (int i=0;i<table.GetLength(1);i++)
    {
        result += table[row, i];
    }
    return result;
}

int GetNumberOfrowWithMinElementsSum(int[,] table)
{
    int min = 0;
    for (int i=0;i<table.GetLength(0);i++)
    {
        if (CountRowElementsSum(table, i) < CountRowElementsSum(table, min)) min = i;
    }
    return min;
}

int[,] myArr = GenerateArray(3, 4, 0, 10);

Console.WriteLine("Сгенерирован массив");
PrintArray(myArr);
Console.WriteLine($"Номер строки с минимальной суммой элементов {GetNumberOfrowWithMinElementsSum(myArr)}(При счёте с ноля)"); */












// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/* int[,] GenerateArray(int rows, int columns, int minVal, int maxVal)
{
    int[,] result = new int[rows, columns];
    for (int i=0;i<rows;i++)
    {
        for (int j=0;j<columns;j++)
        {
            result[i,j] = new Random().Next(minVal, maxVal+1);
        }
    }
    return result;
}

void PrintArray(int[,] table)
{
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
// cij​ равен сумме произведений элементов i строки матрицы A на соответствующие элементы j столбца матрицы B:
// cij=Ai1B1j+Ai2B2j+...+AinBnj
// СДЕЛАЕМ ДОПУЩЕНИЕ, ЧТО МАТРИЦЫ ОДИНАКОВЫЕ ПО РАЗМЕРУ И КВАДРАТНЫЕ
{
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

    for (int i=0;i<result.GetLength(0);i++)
    {
        for (int j=0;j<result.GetLength(0);j++)
        {
            result[i,j] = 0;
            for (int l=0;l<result.GetLength(0);l++)
            {
                result[i,j] += matrix1[i, l] * matrix2[l,j];
            }
        }
    }
    return result;
}

int[,] firstMatrix = GenerateArray(2, 2, 0, 10);
int[,] secondMatrix = GenerateArray(2, 2, 0, 10);

Console.WriteLine("Сгенерирован матрицы");
PrintArray(firstMatrix);
Console.WriteLine("---");
PrintArray(secondMatrix);

int[,] resultMatrix = MultiplyMatrix(firstMatrix, secondMatrix);
Console.WriteLine("Результат усножения матриц");
PrintArray(resultMatrix); */











/* // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GenerateArray(int firstRow, int secondRow, int thirdRow, int minVal, int maxVal)
{
    int[,,] result = new int[firstRow, secondRow, thirdRow];
    for (int i=0;i<firstRow;i++)
    {
        for (int j=0;j<secondRow;j++)
        {
            for (int l=0;l<thirdRow;l++)
            {
                result[i,j,l] = new Random().Next(minVal, maxVal+1);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] table)
{
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            for (int l=0;l<table.GetLength(2);l++)
            {
                Console.WriteLine($"{table[i, j, l]}({i}, {j}, {l})");
            }
        }
    }
}

int[,,] myArr = GenerateArray(2, 2, 2, 0, 10);
PrintArray(myArr);
*/












/*  // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillArray(int[,] table, int number, int row, int column, int direction = 0)
// direction possible variables
// 0 - go right
// 1 - go down
// 2 - go left
// 3 - go up
{
    if (table[row, column] != 0) return;
    table[row, column] = number;
    if (direction == 0)
    {
        if (column + 1 < table.GetLength(1) && table[row, column+1] == 0) FillArray(table, number+1, row, column+1, direction);
        else FillArray(table, number+1, row+1, column, 1);
    }
    if (direction == 1)
    {
        if (row + 1 < table.GetLength(0) && table[row+1, column] == 0) FillArray(table, number+1, row+1, column, direction);
        else FillArray(table, number+1, row, column-1, 2);
    }
    if (direction == 2)
    {
        if (column - 1 >= 0 && table[row, column-1] == 0) FillArray(table, number+1, row, column-1, direction);
        else FillArray(table, number+1, row-1, column, 3);
    }
    if (direction == 3)
    {
        if (row - 1 >= 0 && table[row-1, column] == 0) FillArray(table, number+1, row-1, column, direction);
        else FillArray(table, number+1, row, column+1, 0);
    }    
}

void PrintArray(int[,] table)
{
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            // Console.Write($"{table[i, j]}\t");
            Console.Write("{0:d2} ", table[i, j]);
        }
        Console.WriteLine();
    }
}

int rows = 4, columns = 4;
int[,] myArr = new int[rows, columns];
FillArray(myArr, 1, 0, 0);

PrintArray(myArr); */