Console.Clear();

Console.WriteLine("введите М");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("введите N");
int N = int.Parse(Console.ReadLine());

void PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start == end)return;
    PrintNumbers(start + 1, end);
}

PrintNumbers(M,N);