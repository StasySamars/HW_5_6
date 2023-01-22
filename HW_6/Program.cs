/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

void Number()
{
    Console.Clear();
    Console.WriteLine("Для остановки программы нажите 'q'.\nВведите любые числа и я посчитаю сколько из них больше 0: ");
    bool GoCode = true;
    int result = 0;
    while (GoCode)
    {
        string m = Console.ReadLine();
        if (int.TryParse(m, out int n) && Convert.ToInt32(m) > 0)
        {
            result++;
        }
        else if (m == "q")
        {
            Console.Write($"Вы нажали 'q', Программа остановилась. Введено {result} чисел(а) больше 0.\n");
            GoCode = false;
        }
    }
}

Number();


/* Программа остановится в тот момент когда будет введена “q” до тех пор,
программа считает сколько чисел больше 0 ввел пользователь  */







/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Прямая 1. Введите k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Прямая 1. Введите b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Прямая 2. Введите k2");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Прямая 2. Введите b2");
double b2 = double.Parse(Console.ReadLine());

void CoordinatePointLine(double k1, double k2, double b1, double b2)
{
    Console.Write("Уравнение пересечения прямых:\ny = k1 * x + b1\ny = k2 * x + b1\n\n");
    if (k1 != k2)
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k1 * x + b1;
        // double y2 = k2 * x + b2;                 //y2 == y1
        Console.Write($"x = {x} y1 = {y}");
    }
    else if (k1 == k2 && b1 != b2)
    {
        Console.Write("Две прямые параллельны, a значит, они никогда не пересекутся и система не будет иметь решений");

    }
    else if (k1 == k2 && b1 == b2)
    {
        Console.Write("Две прямые совпали, каждая точка будет решением, а у системы будет бесчисленное множество решений.");
    }
}

CoordinatePointLine(k1, k2, b1, b2);
