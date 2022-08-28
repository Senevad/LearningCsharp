Console.Clear();
Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine()!;
if (number.Length != 5) Console.WriteLine("Число не пятизначное");
else
{
    if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine("да");
    else Console.WriteLine("нет");
}
    