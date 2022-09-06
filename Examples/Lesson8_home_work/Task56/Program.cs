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

int[,] correctArray = GetNewRandomArray(5, 8, 0, 9);
PrintArray(correctArray);

int[] sumArray = new int [correctArray.GetLength(0)];

for (int i = 0; i < correctArray.GetLength(0); i++)
{
    for (int j = 0; j < correctArray.GetLength(1); j++)
    {
        sumArray[i] += correctArray[i,j];
    }
}
Console.WriteLine($"Суммы строк равны [{String.Join(",",sumArray)}]");

int min = 0;
for (int i = 1; i < correctArray.GetLength(0); i++)
{
    if (sumArray[min] > sumArray[i])
    {
       min = i;
    }
}
Console.WriteLine($"{min + 1} строка с минимальной суммой элементов");