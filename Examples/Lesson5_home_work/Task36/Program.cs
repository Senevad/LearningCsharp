Console.Clear();
int [] array = new int [10];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,10);
    if (i % 2 != 0)
    {
        count += array[i];
    }
}
Console.WriteLine($"В массиве [{String.Join(",",array)}] - {count} Сумма элементов стоящих на нечётных позициях");
