Console.Clear();
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= number1; i = i + 2)
{
    Console.Write(i +",");
}
    