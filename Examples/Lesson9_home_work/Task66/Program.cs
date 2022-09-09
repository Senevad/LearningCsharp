Console.Clear();

Console.WriteLine("введите М");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("введите N");
int N = int.Parse(Console.ReadLine());

void PrintNumbers(int start, int end, int sum)
{
    sum += start;
    if (start == end)
    {
        Console.Write($"{sum} ");
        return;
    }
    PrintNumbers(start + 1, end, sum);
}

PrintNumbers(M, N, 0);