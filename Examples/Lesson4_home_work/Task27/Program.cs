Console.Clear();
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number % 10 !=0 || number / 10 !=0)
{
    sum = sum + (number % 10);
    number = number / 10;
}
Console.WriteLine(Math.Abs(sum));