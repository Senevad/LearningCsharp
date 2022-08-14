Console.Clear();
Console.WriteLine("Введите день недели");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 > 0 && number1 < 8 )
{   
    if (number1 >= 6) Console.WriteLine("да это выходной день");
    else Console.WriteLine("нет это рабочий день");
} 
else Console.WriteLine("это не день недели");