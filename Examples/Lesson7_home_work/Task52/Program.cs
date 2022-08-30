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

double[] arxArray = new double[correctArray.GetLength(1)];
double sum = 0;
for (int j = 0; j < correctArray.GetLength(1); j++)
{
    for (int i = 0; i < correctArray.GetLength(0); i++)
    {
        sum += correctArray[i, j];
    }
    arxArray[j] = Math.Round(sum / correctArray.GetLength(0),2);
    sum = 0;
}
Console.WriteLine();
for (int i = 0; i < arxArray.GetLength(0); i++)
{
    Console.Write(String.Format($"{arxArray[i],6}"));
}