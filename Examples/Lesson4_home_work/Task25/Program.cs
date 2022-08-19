Console.Clear();
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());
int AConst = A;
for (int i = 1; i < B; i++)
{
    A = A * AConst;
}
Console.WriteLine(A);