// Написать программу копирования массива

void CopyArray(int[] array)
{
    int[] arr1 = new int[array.Length];
    int[] arr2 = new int[arr1.Length];

    for (int i = 0; i < array.Length; i++)
    {
        arr2[i] = array[i];
        Console.Write($"{arr2[i]} ");
    }
}

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

Console.WriteLine("Ведите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[size];

FillArray(array, 1, 20);
Console.WriteLine("Ваш массив: ");
PrintArray(array);

Console.WriteLine("Скопированный массив: ");
CopyArray(array);