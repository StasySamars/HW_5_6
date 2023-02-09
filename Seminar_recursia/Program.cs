
//

Console.WriteLine("Введи значение N");
int N = int.Parse(Console.ReadLine());
PrintNumbers(1, N);


void PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start == end) return;
    PrintNumbers(start + 1, end);
}
