// Написать программу масштабирования фигуры

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintCoordinate(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        Console.Write($"({array[i + n]},{array[i + n + 1]})");
        n = n++;
    }
    Console.WriteLine();
}

int size = 8;
int[] array = new int[size];

FillArray(array, 0, 3);
Console.WriteLine("Изначальные координаты");
PrintCoordinate(array);

Console.WriteLine("Ведите коэффициент k: ");
int k = int.Parse(Console.ReadLine() ?? "0");

int[] arr = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    arr[i] = array[i] * k;
}
Console.WriteLine($"Координаты при k равном {k}");
PrintCoordinate(arr);


