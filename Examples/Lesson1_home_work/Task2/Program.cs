Console.Clear();
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 >= number2)
{
    Console.WriteLine("первое число '" +number1 +"' больше");
    Console.WriteLine("второе число '" +number2 +"' меньше");
} 
else
{   
    Console.WriteLine("второе число '" +number2 +"' больше");
    Console.WriteLine("первое число '" +number1 +"' меньше");
}