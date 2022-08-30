Console.Clear();
int[,] GetNewRandomArray(int row, int column, int minRandom, int maxRandom)
{
    int[,] randomArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            randomArray[i, j] = new Random().Next(minRandom, maxRandom + 1);
        }
    }
    return randomArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(String.Format($"{inArray[i, j],6}"));
        }
        Console.WriteLine();
    }
}

int[,] correctArray = GetNewRandomArray(new Random().Next(1, 10), new Random().Next(1, 10), 0, 9);
PrintArray(correctArray);

Console.WriteLine("Введите строку элемента");
int row = int.Parse(Console.ReadLine()) - 1;
Console.WriteLine("Введите столбец элемента");
int column = int.Parse(Console.ReadLine()) - 1;
if (correctArray.GetLength(0) >= row
&& correctArray.GetLength(1) >= column
&& row >= 0
&& column >= 0)
{
    Console.WriteLine($"Заданый элемент имеет значение {correctArray[row, column]}");
}
else
{
    Console.WriteLine("Заданый элемент не существует в этом массиве");
}