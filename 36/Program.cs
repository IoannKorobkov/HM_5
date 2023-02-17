// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] arr = PrintArray();
int[] PrintArray()
{
    int x = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[x];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write($" {array[i]}");
    }
    return array;
}
int Sum(int[] array)
{
    int result = 0;
    int i = 0;
    while (i < array.Length)
    {
        result = result + array[i];
        i = i + 2;
    }
    return result;
}

Console.WriteLine();
Console.WriteLine(Sum(arr));