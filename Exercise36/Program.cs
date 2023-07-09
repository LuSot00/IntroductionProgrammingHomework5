// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int SumNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] array = GetArray(10,-100,100);
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Сумма чисел на нечетных позициях --> {SumNumbers(array)}");