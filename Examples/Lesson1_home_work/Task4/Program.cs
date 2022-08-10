Console.Clear();
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 >= number2)
{
    if (number1 >= number3)
    {
        Console.WriteLine("число '" +number1 +"' максимальное");
    }
    else
    {
        Console.WriteLine("число '" +number3 +"' максимальное");
    }
} 
else
{   
    if (number2 >= number3)
    {
        Console.WriteLine("число '" +number2 +"' максимальное");
    }
    else
    {
        Console.WriteLine("число '" +number3 +"' максимальное");
    }
}
