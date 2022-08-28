Console.Clear();
int count = 0;
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < M; i++)
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0)
    {
        count++;
    }
}
Console.WriteLine($"Пользователь ввёл {count} чисел больше 0");