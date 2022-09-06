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

int[,] correctArray = GetNewRandomArray(5, 5, 0, 9);
PrintArray(correctArray);
Console.WriteLine();

for (int i = 0; i < correctArray.GetLength(0); i++)
{
    for (int k = 0; k < correctArray.GetLength(1); k++)
    {
        for (int j = 0; j < correctArray.GetLength(1) - 1; j++)
        {
            if (correctArray[i, j] < correctArray[i, j + 1])
            {
                int temp = correctArray[i, j + 1];
                correctArray[i, j + 1] = correctArray[i, j];
                correctArray[i, j] = temp;
            }
        }
    }
}
PrintArray(correctArray);