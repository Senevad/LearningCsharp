Console.Clear();
Console.WriteLine("Введите число");
string strnumber = Console.ReadLine();
if (strnumber.Length > 2)
{
    int number = Convert.ToInt32(strnumber);
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10 ;
    Console.WriteLine($"третья цифра {number}");
} 
else
{   
    Console.WriteLine("третьей цифры нет");
}