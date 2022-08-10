Console.Clear();
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 % 2 > 0)
{
    Console.WriteLine("число '" +number1 +"' нечётное");
} 
else
{   
    Console.WriteLine("число '" +number1 +"' чётное");
}