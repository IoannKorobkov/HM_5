// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2 
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
int Chetnie(int[] nums)
{
    int count = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 == 0)
            count += 1;
    }
    return count;
}
Console.WriteLine();
Console.WriteLine(Chetnie(arr));

