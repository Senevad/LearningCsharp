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

int[,] matrix1 = GetNewRandomArray(3, 3, 0, 9);
int[,] matrix2 = GetNewRandomArray(3, 3, 0, 9);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();

int[,] resultMatrix = new int [matrix1.GetLength(0),matrix2.GetLength(1)];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            int multip = matrix1[i,k] * matrix2 [k,j] ;
            resultMatrix[i,j] += multip;
        }
        
    }
}
Console.WriteLine("рузультирующая матрица:");
PrintArray(resultMatrix);