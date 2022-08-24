Console.Clear();
int [] array = new int [10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99,100);
}
int min = array[0];
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}
int result = max - min;
Console.WriteLine($"В массиве [{String.Join(",",array)}] - {result} разница между максимальным и минимальным элементом массива");