Console.Clear();

Console.WriteLine("введите М");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("введите N");
int N = int.Parse(Console.ReadLine());

Console.WriteLine(FunctionAcr(M, N));

int FunctionAcr(int numM, int numN)
{
    if (numM == 0) return (numN + 1);
    else if (numM != 0 && numN == 0) return FunctionAcr(numM - 1, 1);
    else return FunctionAcr(numM - 1, FunctionAcr(numM, numN - 1));
}