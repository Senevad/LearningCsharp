Console.Clear();

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

int[,] array = new int[4, 4];
int number = 1;

for (int i = 0; i < 2; i++)
{
    for (int j = i; j < 4 - i; j++)
    {
        array[i,j] = number;
        number++;
    }
    for (int j = i + 1; j < 4 - i; j++)
    {
        array[j,3-i] = number;
        number++;
    }
    for (int j = 3 - i; j > i; j--)
    {
        array[3-i,j-1] = number;
        number++;
    }
    for (int j = 3-i; j > i + 1; j--)
    {
        array[j-1,i] = number;
        number++;
    }
}

PrintArray(array);