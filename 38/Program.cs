// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double[] arr = PrintArray();
double[] PrintArray()
{
    int x = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[x];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(), 2);
        Console.Write($" {array[i]}");
    }
    return array;
}
double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}
double Max(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}
double result = Max(arr) - Min(arr);
Console.WriteLine();
Console.WriteLine($"Разница Между максимальным и минимальным числом = {Max(arr)}");
Console.WriteLine(Min(arr));
Console.WriteLine(result);
