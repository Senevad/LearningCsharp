Console.Clear();
Console.WriteLine("Введите число строк");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int column = int.Parse(Console.ReadLine());
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        double[,] array = new double[row,column];
        array[i,j] = Math.Round(new Random().NextDouble(),1) + new Random().Next(-9,10);
        Console.Write(String.Format($"{array[i,j],6}"));
    }
    Console.WriteLine();
}